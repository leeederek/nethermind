// SPDX-FileCopyrightText: 2023 Demerzel Solutions Limited
// SPDX-License-Identifier: LGPL-3.0-only

using System.Runtime.CompilerServices;

namespace Nethermind.Crypto.Blake2;

/// <summary>
///     Code adapted from Blake2Fast (https://github.com/saucecontrol/Blake2Fast)
/// </summary>
public unsafe partial class Blake2Compression
{
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    [SkipLocalsInit]
    private static void ComputeScalar(ulong* sh, ulong* m, uint rounds)
    {
        ulong m00 = m[00];
        ulong m01 = m[01];
        ulong m02 = m[02];
        ulong m03 = m[03];
        ulong m04 = m[04];
        ulong m05 = m[05];
        ulong m06 = m[06];
        ulong m07 = m[07];
        ulong m08 = m[08];
        ulong m09 = m[09];
        ulong m10 = m[10];
        ulong m11 = m[11];
        ulong m12 = m[12];
        ulong m13 = m[13];
        ulong m14 = m[14];
        ulong m15 = m[15];

        ulong v00 = sh[0];
        ulong v01 = sh[1];
        ulong v02 = sh[2];
        ulong v03 = sh[3];
        ulong v04 = sh[4];
        ulong v05 = sh[5];
        ulong v06 = sh[6];
        ulong v07 = sh[7];

        ulong v08 = 0x6A09E667F3BCC908ul;
        ulong v09 = 0xBB67AE8584CAA73Bul;
        ulong v10 = 0x3C6EF372FE94F82Bul;
        ulong v11 = 0xA54FF53A5F1D36F1ul;
        ulong v12 = 0x510E527FADE682D1ul;
        ulong v13 = 0x9B05688C2B3E6C1Ful;
        ulong v14 = 0x1F83D9ABFB41BD6Bul;
        ulong v15 = 0x5BE0CD19137E2179ul;

        v12 ^= sh[8]; // t[0]
        v13 ^= sh[9]; // t[1]
        v14 ^= sh[10]; // f[0]

        for (uint i = 0; i < rounds; i++)
        {
            //ROUND 1
            v00 += m00;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v01 += m02;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v02 += m04;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v03 += m06;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v02 += m05;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 63) ^ (v06 << 1);

            v03 += m07;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v00 += m01;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v01 += m03;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v00 += m08;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v01 += m10;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v02 += m12;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v03 += m14;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v02 += m13;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v03 += m15;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v00 += m09;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v01 += m11;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 63) ^ (v06 << 1);

            if (++i == rounds) break;

            //ROUND 2
            v00 += m14;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v01 += m04;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v02 += m09;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v03 += m13;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v02 += m15;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 63) ^ (v06 << 1);

            v03 += m06;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v00 += m10;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v01 += m08;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v00 += m01;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v01 += m00;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v02 += m11;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v03 += m05;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v02 += m07;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v03 += m03;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v00 += m12;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v01 += m02;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 63) ^ (v06 << 1);

            if (++i == rounds) break;

            //ROUND 3
            v00 += m11;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v01 += m12;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v02 += m05;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v03 += m15;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v02 += m02;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 63) ^ (v06 << 1);

            v03 += m13;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v00 += m08;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v01 += m00;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v00 += m10;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v01 += m03;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v02 += m07;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v03 += m09;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v02 += m01;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v03 += m04;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v00 += m14;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v01 += m06;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 63) ^ (v06 << 1);

            if (++i == rounds) break;

            //ROUND 4
            v00 += m07;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v01 += m03;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v02 += m13;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v03 += m11;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v02 += m12;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 63) ^ (v06 << 1);

            v03 += m14;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v00 += m09;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v01 += m01;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v00 += m02;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v01 += m05;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v02 += m04;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v03 += m15;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v02 += m00;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v03 += m08;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v00 += m06;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v01 += m10;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 63) ^ (v06 << 1);

            if (++i == rounds) break;

            //ROUND 5
            v00 += m09;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v01 += m05;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v02 += m02;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v03 += m10;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v02 += m04;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 63) ^ (v06 << 1);

            v03 += m15;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v00 += m00;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v01 += m07;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v00 += m14;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v01 += m11;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v02 += m06;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v03 += m03;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v02 += m08;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v03 += m13;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v00 += m01;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v01 += m12;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 63) ^ (v06 << 1);

            if (++i == rounds) break;

            //ROUND 6
            v00 += m02;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v01 += m06;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v02 += m00;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v03 += m08;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v02 += m11;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 63) ^ (v06 << 1);

            v03 += m03;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v00 += m12;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v01 += m10;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v00 += m04;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v01 += m07;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v02 += m15;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v03 += m01;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v02 += m14;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v03 += m09;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v00 += m13;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v01 += m05;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 63) ^ (v06 << 1);

            if (++i == rounds) break;

            //ROUND 7
            v00 += m12;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v01 += m01;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v02 += m14;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v03 += m04;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v02 += m13;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 63) ^ (v06 << 1);

            v03 += m10;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v00 += m05;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v01 += m15;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v00 += m00;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v01 += m06;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v02 += m09;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v03 += m08;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v02 += m02;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v03 += m11;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v00 += m07;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v01 += m03;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 63) ^ (v06 << 1);

            if (++i == rounds) break;

            //ROUND 8
            v00 += m13;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v01 += m07;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v02 += m12;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v03 += m03;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v02 += m01;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 63) ^ (v06 << 1);

            v03 += m09;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v00 += m11;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v01 += m14;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v00 += m05;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v01 += m15;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v02 += m08;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v03 += m02;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v02 += m06;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v03 += m10;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v00 += m00;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v01 += m04;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 63) ^ (v06 << 1);

            if (++i == rounds) break;

            //ROUND 9
            v00 += m06;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v01 += m14;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v02 += m11;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v03 += m00;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v02 += m03;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 63) ^ (v06 << 1);

            v03 += m08;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v00 += m15;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v01 += m09;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v00 += m12;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v01 += m13;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v02 += m01;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v03 += m10;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v02 += m04;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v03 += m05;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v00 += m02;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v01 += m07;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 63) ^ (v06 << 1);

            if (++i == rounds) break;

            //ROUND 10
            v00 += m10;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v01 += m08;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v02 += m07;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v03 += m01;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v02 += m06;
            v02 += v06;
            v14 ^= v02;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v10 += v14;
            v06 ^= v10;
            v06 = (v06 >> 63) ^ (v06 << 1);

            v03 += m05;
            v03 += v07;
            v15 ^= v03;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v11 += v15;
            v07 ^= v11;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v00 += m02;
            v00 += v04;
            v12 ^= v00;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v08 += v12;
            v04 ^= v08;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v01 += m04;
            v01 += v05;
            v13 ^= v01;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v09 += v13;
            v05 ^= v09;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v00 += m15;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 32) ^ (v15 << 32);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 24) ^ (v05 << 40);

            v01 += m09;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 32) ^ (v12 << 32);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 24) ^ (v06 << 40);

            v02 += m03;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 32) ^ (v13 << 32);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 24) ^ (v07 << 40);

            v03 += m13;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 32) ^ (v14 << 32);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 24) ^ (v04 << 40);

            v02 += m12;
            v02 += v07;
            v13 ^= v02;
            v13 = (v13 >> 16) ^ (v13 << 48);
            v08 += v13;
            v07 ^= v08;
            v07 = (v07 >> 63) ^ (v07 << 1);

            v03 += m00;
            v03 += v04;
            v14 ^= v03;
            v14 = (v14 >> 16) ^ (v14 << 48);
            v09 += v14;
            v04 ^= v09;
            v04 = (v04 >> 63) ^ (v04 << 1);

            v00 += m11;
            v00 += v05;
            v15 ^= v00;
            v15 = (v15 >> 16) ^ (v15 << 48);
            v10 += v15;
            v05 ^= v10;
            v05 = (v05 >> 63) ^ (v05 << 1);

            v01 += m14;
            v01 += v06;
            v12 ^= v01;
            v12 = (v12 >> 16) ^ (v12 << 48);
            v11 += v12;
            v06 ^= v11;
            v06 = (v06 >> 63) ^ (v06 << 1);
        }

        sh[0] ^= v00 ^ v08;
        sh[1] ^= v01 ^ v09;
        sh[2] ^= v02 ^ v10;
        sh[3] ^= v03 ^ v11;
        sh[4] ^= v04 ^ v12;
        sh[5] ^= v05 ^ v13;
        sh[6] ^= v06 ^ v14;
        sh[7] ^= v07 ^ v15;
    }
}
