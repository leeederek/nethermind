// SPDX-FileCopyrightText: 2023 Demerzel Solutions Limited
// SPDX-License-Identifier: LGPL-3.0-only

using System;
using System.Buffers;
using Nethermind.Core.Buffers;

namespace Nethermind.Db
{
    public interface IDbWithSpan : IDb
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Can return null or empty Span on missing key</returns>
        Span<byte> GetSpan(ReadOnlySpan<byte> key);
        void PutSpan(ReadOnlySpan<byte> key, ReadOnlySpan<byte> value);
        void DangerousReleaseMemory(in Span<byte> span);
        MemoryManager<byte> GetOwnedMemory(ReadOnlySpan<byte> key)
        {
            Span<byte> span = GetSpan(key);
            return new DbSpanMemoryManager(this, span);
        }
    }
}
