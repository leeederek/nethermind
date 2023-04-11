// SPDX-FileCopyrightText: 2022 Demerzel Solutions Limited
// SPDX-License-Identifier: LGPL-3.0-only

using System.Threading.Tasks;
using FluentAssertions;
using Nethermind.Blockchain.FullPruning;
using Nethermind.Core.Extensions;
using Nethermind.Core.Test.Builders;
using Nethermind.Db;
using Nethermind.Db.FullPruning;
using Nethermind.Logging;
using Nethermind.State;
using Nethermind.Trie;
using Nethermind.Trie.Pruning;
using NSubstitute;
using NUnit.Framework;

namespace Nethermind.Blockchain.Test.FullPruning
{
    [Parallelizable(ParallelScope.All)]
    public class CopyTreeVisitorTests
    {
        [TestCase(0, 1)]
        [TestCase(0, 8)]
        [TestCase(1, 1)]
        [TestCase(1, 8)]
        [Timeout(Timeout.MaxTestTime)]
        public void copies_state_between_dbs(int fullPruningMemoryBudgetMb, int maxDegreeOfParallelism)
        {
            MemDb trieDb = new();
            MemDb clonedDb = new();

            VisitingOptions visitingOptions = new()
            {
                MaxDegreeOfParallelism = maxDegreeOfParallelism,
                FullScanMemoryBudget = fullPruningMemoryBudgetMb.MiB(),
            };

            CopyDb(StartPruning(trieDb, clonedDb), trieDb, clonedDb, visitingOptions);

            clonedDb.Count.Should().Be(132);
            clonedDb.Keys.Should().BeEquivalentTo(trieDb.Keys);
            clonedDb.Values.Should().BeEquivalentTo(trieDb.Values);
        }

        [Test, Timeout(Timeout.MaxTestTime)]
        public async Task cancel_coping_state_between_dbs()
        {
            MemDb trieDb = new();
            MemDb clonedDb = new();
            IPruningContext pruningContext = StartPruning(trieDb, clonedDb);
            Task task = Task.Run(() => CopyDb(pruningContext, trieDb, clonedDb));

            pruningContext?.CancellationTokenSource.Cancel();

            await task;

            clonedDb.Count.Should().BeLessThan(trieDb.Count);
        }

        private static IPruningContext CopyDb(IPruningContext pruningContext, MemDb trieDb, MemDb clonedDb, VisitingOptions visitingOptions = null)
        {
            LimboLogs logManager = LimboLogs.Instance;
            PatriciaTree trie = Build.A.Trie(trieDb).WithAccountsByIndex(0, 100).TestObject;
            IStateReader stateReader = new StateReader(new TrieStore(trieDb, logManager), new MemDb(), logManager);

            using CopyTreeVisitor copyTreeVisitor = new(pruningContext, new ChainSizes.UnknownChain(), logManager);
            stateReader.RunTreeVisitor(copyTreeVisitor, trie.RootHash, visitingOptions);
            return pruningContext;
        }

        private static IPruningContext StartPruning(MemDb trieDb, MemDb clonedDb)
        {
            IRocksDbFactory rocksDbFactory = Substitute.For<IRocksDbFactory>();
            rocksDbFactory.CreateDb(Arg.Any<RocksDbSettings>()).Returns(trieDb, clonedDb);

            FullPruningDb fullPruningDb = new(new RocksDbSettings("test", "test"), rocksDbFactory);
            fullPruningDb.TryStartPruning(out IPruningContext pruningContext);
            return pruningContext;
        }
    }
}
