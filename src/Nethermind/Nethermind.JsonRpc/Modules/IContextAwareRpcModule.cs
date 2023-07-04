// SPDX-FileCopyrightText: 2023 Demerzel Solutions Limited
// SPDX-License-Identifier: LGPL-3.0-only

namespace Nethermind.JsonRpc.Modules
{
    public interface IContextAwareRpcModule : IRpcModule
    {
        public JsonRpcContext Context { get; set; }
    }
}
