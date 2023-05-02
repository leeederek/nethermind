// SPDX-FileCopyrightText: 2023 Demerzel Solutions Limited
// SPDX-License-Identifier: LGPL-3.0-only

namespace Nethermind.Blockchain.Receipts;

public class ReceiptConfig : IReceiptConfig
{
    public bool StoreReceipts { get; set; } = true;
    public bool ReceiptsMigration { get; set; } = false;
    public bool CompactReceiptStore { get; set; } = false;
    public bool CompactTxIndex { get; set; } = false;
    public long? TxLookupLimit { get; set; } = 0;
}
