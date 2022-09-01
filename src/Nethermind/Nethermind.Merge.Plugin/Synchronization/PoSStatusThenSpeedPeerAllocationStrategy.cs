﻿//  Copyright (c) 2021 Demerzel Solutions Limited
//  This file is part of the Nethermind library.
//
//  The Nethermind library is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  The Nethermind library is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with the Nethermind. If not, see <http://www.gnu.org/licenses/>.
//

using System;
using System.Collections.Generic;
using Nethermind.Blockchain;
using Nethermind.Consensus;
using Nethermind.Stats;
using Nethermind.Synchronization.Peers;
using Nethermind.Synchronization.Peers.AllocationStrategies;

namespace Nethermind.Merge.Plugin.Synchronization;

public class PoSStatusThenSpeedPeerAllocationStrategy : IPeerAllocationStrategy
{
    private readonly IBeaconPivot _beaconPivot;
    private readonly IPoSSwitcher _poSSwitcher;
    private readonly TransferSpeedType _speedType;

    private const decimal MinDiffPercentageForSpeedSwitch = 0.10m;
    private const int MinDiffForSpeedSwitch = 10;
    int nullSpeed = -1;

    public PoSStatusThenSpeedPeerAllocationStrategy(IBeaconPivot beaconPivot, IPoSSwitcher poSSwitcher, TransferSpeedType speedType)
    {
        _beaconPivot = beaconPivot;
        _poSSwitcher = poSSwitcher;
        _speedType = speedType;
    }

    public bool CanBeReplaced => true;

    private long? GetSpeed(INodeStatsManager nodeStatsManager, PeerInfo peerInfo)
    {
        long? bodiesSpeed = nodeStatsManager.GetOrAdd(peerInfo.SyncPeer.Node)
            .GetAverageTransferSpeed(_speedType);
        if (bodiesSpeed == null)
        {
            return null;
        }

        return bodiesSpeed ?? 0;
    }

    private PeerInfoComparison CreatePeerInfoComparison(PeerInfo? currentPeer, INodeStatsManager nodeStatsManager)
    {
        if (currentPeer == null)
        {
            return new PeerInfoComparison
            {
                Info = currentPeer,
                TransferSpeed = null,
                TDSameAsFTTD = false,
            };
        }

        return new PeerInfoComparison
        {
            Info = currentPeer,
            TransferSpeed = GetSpeed(nodeStatsManager, currentPeer),
            TDSameAsFTTD = _poSSwitcher.FinalTotalDifficulty != null && currentPeer.TotalDifficulty == _poSSwitcher.FinalTotalDifficulty
        };
    }

    public PeerInfo? Allocate(PeerInfo? currentPeer, IEnumerable<PeerInfo> peers, INodeStatsManager nodeStatsManager,
        IBlockTree blockTree)
    {
        int peersCount = 0;

        PeerInfoComparison bestPeer = CreatePeerInfoComparison(currentPeer, nodeStatsManager);
        bestPeer.TransferSpeed ??= nullSpeed; // Special case
        long currentSpeed = bestPeer.TransferSpeed ?? nullSpeed;

        foreach (PeerInfo info in peers)
        {
            (this as IPeerAllocationStrategy).CheckAsyncState(info);
            peersCount++;

            if (ShouldSkipPeer(blockTree, info)) continue;

            PeerInfoComparison currentPeerInfo = CreatePeerInfoComparison(info, nodeStatsManager);
            if (currentPeerInfo.IsBetterThan(bestPeer))
            {
                bestPeer = currentPeerInfo;
            }
        }

        if (peersCount == 0)
        {
            return currentPeer;
        }

        decimal speedRatio = bestPeer.TransferSpeed ?? 0 / (decimal)Math.Max(1L, currentSpeed);
        if (speedRatio > 1m + MinDiffPercentageForSpeedSwitch
            && bestPeer.TransferSpeed - currentSpeed > MinDiffForSpeedSwitch)
        {
            return bestPeer.Info;
        }

        return currentPeer ?? bestPeer.Info;
    }

    private bool ShouldSkipPeer(IBlockTree blockTree, PeerInfo info)
    {
        if (_beaconPivot.BeaconPivotExists())
        {
            if (info.HeadNumber < _beaconPivot.PivotNumber - 1)
            {
                // we need to guarantee the peer can have all the block prior to beacon pivot
                return true;
            }
        }
        else if (info.HeadNumber < (blockTree.BestSuggestedBody?.Number ?? 0))
        {
            return true;
        }

        return false;
    }

    struct PeerInfoComparison
    {
        public PeerInfo? Info { get; set; }
        public long? TransferSpeed { get; set; }
        public bool TDSameAsFTTD { get; set; }

        public bool IsBetterThan(PeerInfoComparison otherPeer)
        {
            if (Info == null) return false;
            if (otherPeer.Info == null) return true;

            // Prioritize probably PoS peer
            // We may not have FTTD, or the TD of the peer, so this is a priority instead of a
            // filter
            if (TDSameAsFTTD && !otherPeer.TDSameAsFTTD) return true;

            if (Info!.SyncPeer.ReachedPoS && !otherPeer.Info.SyncPeer.ReachedPoS) return true;

            // TODO: On peer refresh, if the difficulty is 0, add marker to peer that the peer has reached PoS.

            return (TransferSpeed ?? 0) > (otherPeer.TransferSpeed ?? 0);
        }
    }
}
