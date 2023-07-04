// SPDX-FileCopyrightText: 2023 Demerzel Solutions Limited
// SPDX-License-Identifier: LGPL-3.0-only

using System;

namespace Nethermind.AccountAbstraction.Bundler
{
    public interface IBundleTrigger
    {
        event EventHandler<BundleUserOpsEventArgs>? TriggerBundle;
    }
}
