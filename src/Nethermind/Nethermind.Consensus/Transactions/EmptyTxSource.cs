// SPDX-FileCopyrightText: 2023 Demerzel Solutions Limited
// SPDX-License-Identifier: LGPL-3.0-only

using System;
using System.Collections.Generic;
using Nethermind.Core;

namespace Nethermind.Consensus.Transactions
{
    public class EmptyTxSource : ITxSource
    {
        private EmptyTxSource() { }

        public static ITxSource Instance { get; } = new EmptyTxSource();

        public IEnumerable<Transaction> GetTransactions(BlockHeader parent, long gasLimit)
        {
            return Array.Empty<Transaction>();
        }
    }
}
