//  Copyright (c) 2021 Demerzel Solutions Limited
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

using FluentAssertions;
using Nethermind.Core.Extensions;
using Nethermind.Core.Specs;
using Nethermind.Specs;
using Nethermind.Core.Test.Builders;
using NUnit.Framework;
using Nethermind.Specs.Forks;
using NSubstitute;
using Nethermind.Evm.CodeAnalysis;
using Nethermind.Blockchain;
using System;
using static Nethermind.Evm.CodeAnalysis.ByteCodeValidator;
using System.Collections.Generic;
using System.Linq;
using Nethermind.Evm.Tracing;
using Nethermind.Evm.Tracing.GethStyle;
using Nethermind.Int256;
using Nethermind.Core;
using Nethermind.Evm.TransactionProcessing;
using Nethermind.Logging;
using Nethermind.Specs.Test;
using System.Text.Json;
using TestCase = Nethermind.Evm.Test.EofTestsBase.TestCase;
using static Nethermind.Evm.Test.EofTestsBase;

namespace Nethermind.Evm.Test
{
    /// <summary>
    /// https://gist.github.com/holiman/174548cad102096858583c6fbbb0649a
    /// </summary>
    public class EOF4200Tests
    {
        private EofTestsBase Instance => EofTestsBase.Instance(SpecProvider);
        protected ISpecProvider SpecProvider => new TestSpecProvider(Frontier.Instance, new OverridableReleaseSpec(Shanghai.Instance)
        {
            IsEip4750Enabled = false,
            IsEip5450Enabled = false,
        });

        public static IEnumerable<TestCase> Eip4200TxTestCases
        {
            get
            {
                yield return ScenarioCase.CreateFromBytecode(
                    BytecodeTypes.EvmObjectFormat,
                    bytecodes: new[] {
                        Prepare.EvmCode
                                .RJUMP(1)
                                .INVALID()
                                .JUMPDEST()
                                .MSTORE8(0, new byte[] { 1 })
                                .RETURN(0, 1)
                                .RJUMP(-13)
                                .STOP()
                                .Done
                    },
                    databytes: Array.Empty<byte>(),
                    expectedResults: (StatusCode.Success, null)
                );

                yield return ScenarioCase.CreateFromBytecode(
                    BytecodeTypes.EvmObjectFormat,
                    bytecodes: new[] {
                        Prepare.EvmCode
                                .RJUMPI(1, new byte[] { 1 })
                                .INVALID()
                                .JUMPDEST()
                                .MSTORE8(0, new byte[] { 1 })
                                .RETURN(0, 1)
                                .RJUMP(-13)
                                .STOP()
                                .Done
                    },
                    databytes: Array.Empty<byte>(),
                    expectedResults: (StatusCode.Success, null)
                );

                yield return ScenarioCase.CreateFromBytecode(
                    BytecodeTypes.EvmObjectFormat,
                    bytecodes: new[] {
                        Prepare.EvmCode
                                .RJUMP(11)
                                .INVALID()
                                .MSTORE8(0, new byte[] { 1 })
                                .RETURN(0, 1)
                                .RJUMP(-13)
                                .STOP()
                                .Done
                    },
                    databytes: Array.Empty<byte>(),
                    expectedResults: (StatusCode.Success, null)
                );

                yield return ScenarioCase.CreateFromBytecode(
                    BytecodeTypes.EvmObjectFormat,
                    bytecodes: new[] {
                        Prepare.EvmCode
                                .RJUMP(0)
                                .MSTORE8(0, new byte[] { 1 })
                                .RETURN(0, 1)
                                .Done
                    },
                    databytes: Array.Empty<byte>(),
                    expectedResults: (StatusCode.Success, null)
                );

                yield return ScenarioCase.CreateFromBytecode(
                    BytecodeTypes.EvmObjectFormat,
                    bytecodes: new[] {
                        Prepare.EvmCode
                                .RJUMPI(10, new byte[] { 1 })
                                .MSTORE8(0, new byte[] { 2 })
                                .RETURN(0, 1)
                                .MSTORE8(0, new byte[] { 1 })
                                .RETURN(0, 1)
                                .Done
                    },
                    databytes: Array.Empty<byte>(),
                    expectedResults: (StatusCode.Success, null)
                );

                yield return ScenarioCase.CreateFromBytecode(
                    BytecodeTypes.EvmObjectFormat,
                    bytecodes: new[] {
                        Prepare.EvmCode
                                .RJUMPI(10, new byte[] { 0 })
                                .MSTORE8(0, new byte[] { 2 })
                                .RETURN(0, 1)
                                .MSTORE8(0, new byte[] { 1 })
                                .RETURN(0, 1)
                                .Done
                    },
                    databytes: Array.Empty<byte>(),
                    expectedResults: (StatusCode.Success, null)
                );

                yield return ScenarioCase.CreateFromBytecode(
                    BytecodeTypes.EvmObjectFormat,
                    bytecodes: new[] {
                        Prepare.EvmCode
                                .RJUMP(11)
                                .COINBASE()
                                .MSTORE8(0, new byte[] { 1 })
                                .RETURN(0, 1)
                                .RJUMPI(-16, new byte[] { 1 })
                                .MSTORE8(0, new byte[] { 2 })
                                .RETURN(0, 1)
                                .Done
                    },
                    databytes: Array.Empty<byte>(),
                    expectedResults: (StatusCode.Success, null)
                );

                yield return ScenarioCase.CreateFromBytecode(
                    BytecodeTypes.EvmObjectFormat,
                    bytecodes: new[] {
                        Prepare.EvmCode
                                .RJUMP(11)
                                .COINBASE()
                                .MSTORE8(0, new byte[] { 1 })
                                .RETURN(0, 1)
                                .RJUMPI(-16, new byte[] { 0 })
                                .MSTORE8(0, new byte[] { 2 })
                                .RETURN(0, 1)
                                .Done
                    },
                    databytes: Array.Empty<byte>(),
                    expectedResults: (StatusCode.Success, null)
                );

                yield return ScenarioCase.CreateFromBytecode(
                    BytecodeTypes.EvmObjectFormat,
                    bytecodes: new[] {
                        Prepare.EvmCode
                                .RJUMPI(0, new byte[] { 0 })
                                .MSTORE8(0, new byte[] { 1 })
                                .RETURN(0, 1)
                                .Done
                    },
                    databytes: Array.Empty<byte>(),
                    expectedResults: (StatusCode.Success, null)
                );

                yield return ScenarioCase.CreateFromBytecode(
                    BytecodeTypes.EvmObjectFormat,
                    bytecodes: new[] {
                        Prepare.EvmCode
                                .RJUMPI(0, new byte[] { 1 })
                                .MSTORE8(0, new byte[] { 1 })
                                .RETURN(0, 1).Done
                    },
                    databytes: Array.Empty<byte>(),
                    expectedResults: (StatusCode.Success, null)
                );

                yield return ScenarioCase.CreateFromBytecode(
                    BytecodeTypes.EvmObjectFormat,
                    bytecodes: new[] {
                        Prepare.EvmCode
                                .RJUMPV(new short[] { 1, 2, 4 }, 1)
                                .INVALID()
                                .INVALID()
                                .PushData(2)
                                .PushData(3)
                                .MSTORE8(0, new byte[] { 1 })
                                .RETURN(0, 1)
                                .Done
                    },
                    databytes: Array.Empty<byte>(),
                    expectedResults: (StatusCode.Success, null)
                );

                yield return ScenarioCase.CreateFromBytecode(
                    BytecodeTypes.EvmObjectFormat,
                    bytecodes: new[] {
                        Prepare.EvmCode
                                .RJUMPV(new short[] { 1, 6 }, 0)
                                .INVALID()
                                .ADD(2, 3)
                                .MSTORE8(0, new byte[] { 1 })
                                .RETURN(0, 1)
                                .Done
                    },
                    databytes: Array.Empty<byte>(),
                    expectedResults: (StatusCode.Success, null)
                );

                yield return ScenarioCase.CreateFromBytecode(
                    BytecodeTypes.EvmObjectFormat,
                    bytecodes: new[] {
                        Prepare.EvmCode
                                .RJUMPV(new short[] { 0, 5 }, 4)
                                .ADD(2, 3)
                                .MSTORE8(0, new byte[] { 1 })
                                .RETURN(0, 1)
                                .Done
                    },
                    databytes: Array.Empty<byte>(),
                    expectedResults: (StatusCode.Success, null)
                );

                yield return ScenarioCase.CreateFromBytecode(
                    BytecodeTypes.EvmObjectFormat,
                    bytecodes: new[] {
                        Prepare.EvmCode
                                .RJUMPV(new short[] { }, 0)
                                .MSTORE8(0, new byte[] { 1 })
                                .RETURN(0, 1)
                                .Done
                    },
                    databytes: Array.Empty<byte>(),
                    expectedResults: (StatusCode.Failure, "Scenario : Truncated Jumptable")
                );

                yield return ScenarioCase.CreateFromBytecode(
                    BytecodeTypes.EvmObjectFormat,
                    bytecodes: new[] {
                        Prepare.EvmCode
                                .RJUMPV(new short[] { 1 }, 0)
                                .MSTORE8(0, new byte[] { 1 })
                                .RETURN(0, 1)
                                .Done
                    },
                    databytes: Array.Empty<byte>(),
                    expectedResults: (StatusCode.Failure, "Jump to Push Immediate")
                );

                yield return ScenarioCase.CreateFromBytecode(
                    BytecodeTypes.EvmObjectFormat,
                    bytecodes: new[] {
                        Prepare.EvmCode
                                .RJUMPV(new short[] { 5 }, 0)
                                .Done
                    },
                    databytes: Array.Empty<byte>(),
                    expectedResults: (StatusCode.Failure, "Jumpv Destination Outside of Bounds")
                );

                yield return ScenarioCase.CreateFromBytecode(
                    BytecodeTypes.EvmObjectFormat,
                    bytecodes: new[] {
                        Prepare.EvmCode
                                .RJUMPV(new short[] { 1 }, 0)
                                .Done
                    },
                    databytes: Array.Empty<byte>(),
                    expectedResults: (StatusCode.Failure, "Jumpv cant be last Instruction")
                );
            }
        }

        [Test]
        public void EOF_Static_jumps_activation_tests()
        {
            var TargetReleaseSpec = new OverridableReleaseSpec(Shanghai.Instance);

            Instruction[] StaticRelativeJumpsOpcode =
            {
                Instruction.RJUMP,
                Instruction.RJUMPI,
                Instruction.RJUMPV,
            };

            foreach (Instruction opcode in StaticRelativeJumpsOpcode)
            {
                Assert.True(opcode.IsValid(TargetReleaseSpec));
            }
        }

        [Test]
        public void EOF_execution_tests([ValueSource(nameof(Eip4200TxTestCases))] TestCase testcase)
        {
            TestAllTracerWithOutput receipts = Instance.EOF_contract_execution_tests(testcase.Bytecode);

            receipts.StatusCode.Should().Be(testcase.Result.Status, $"{testcase.Result.Msg}");
        }

        [Test]
        public void EOF_validation_tests([ValueSource(nameof(Eip4200TxTestCases))] TestCase testcase)
        {
            var TargetReleaseSpec = new OverridableReleaseSpec(Shanghai.Instance)
            {
                IsEip4750Enabled = false,
                IsEip5450Enabled = false,
            };

            Instance.EOF_contract_header_parsing_tests(testcase, TargetReleaseSpec);
        }
    }
}