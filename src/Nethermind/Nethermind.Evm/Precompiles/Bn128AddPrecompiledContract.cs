/*
 * Copyright (c) 2018 Demerzel Solutions Limited
 * This file is part of the Nethermind library.
 *
 * The Nethermind library is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * The Nethermind library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with the Nethermind. If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Numerics;
using Nethermind.Core.Crypto.ZkSnarks;
using Nethermind.Core.Extensions;

namespace Nethermind.Evm.Precompiles
{
    /// <summary>
    ///     Code adapted from ethereumJ (https://github.com/ethereum/ethereumj)
    /// </summary>
    public class Bn128AddPrecompiledContract : IPrecompiledContract
    {
        public static IPrecompiledContract Instance = new Bn128AddPrecompiledContract();

        private Bn128AddPrecompiledContract()
        {
        }

        public BigInteger Address => 6;

        public long BaseGasCost()
        {
            return 500L;
        }

        public long DataGasCost(byte[] inputData)
        {
            return 0L;
        }

        public byte[] Run(byte[] inputData)
        {  
            if (inputData == null)
            {
                inputData = Bytes.Empty;
            }

            if (inputData.Length < 128)
            {
                inputData = inputData.PadRight(128);
            }

            byte[] x1 = inputData.Slice(0, 32);
            byte[] y1 = inputData.Slice(32, 32);

            byte[] x2 = inputData.Slice(64, 32);
            byte[] y2 = inputData.Slice(96, 32);

            Bn128Fp p1 = Bn128Fp.Create(x1, y1);
            if (p1 == null)
            {
                throw new ArgumentException(); // TODO: check the behaviour here
            }

            Bn128Fp p2 = Bn128Fp.Create(x2, y2);
            if (p2 == null)
            {
                throw new ArgumentException(); // TODO: check the behaviour here
            }

            Bn128Fp res = p1.Add(p2).ToEthNotation();

            return EncodeResult(res.X.GetBytes(), res.Y.GetBytes());
        }
        
        private static byte[] EncodeResult(byte[] w1, byte[] w2) {

            byte[] result = new byte[64];

            w1 = w1.WithoutLeadingZeros();
            w2 = w2.WithoutLeadingZeros();

            // TODO: do I need to strip leading zeros here?
            Buffer.BlockCopy(w1, 0, result, 32 - w1.Length, w1.Length);
            Buffer.BlockCopy(w2, 0, result, 64 - w2.Length, w2.Length);

            return result;
        }
    }
}