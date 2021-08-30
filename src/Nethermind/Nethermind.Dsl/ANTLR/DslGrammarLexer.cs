//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from DslGrammar.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class DslGrammarLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		BOOLEAN_OPERATOR=1, ARITHMETIC_SYMBOL=2, WATCH=3, WHERE=4, PUBLISH=5, 
		AND=6, OR=7, CONTAINS=8, IS=9, NOT=10, PUBLISH_VALUE=11, WEBSOCKETS=12, 
		TELEGRAM=13, DISCORD=14, SLACK=15, URL=16, WORD=17, DIGIT=18, BYTECODE=19, 
		ADDRESS=20, WS=21;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"BOOLEAN_OPERATOR", "ARITHMETIC_SYMBOL", "WATCH", "WHERE", "PUBLISH", 
		"AND", "OR", "CONTAINS", "IS", "NOT", "PUBLISH_VALUE", "WEBSOCKETS", "TELEGRAM", 
		"DISCORD", "SLACK", "URL", "WORD", "DIGIT", "BYTECODE", "ADDRESS", "WS"
	};


	public DslGrammarLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public DslGrammarLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, "'WATCH'", "'WHERE'", "'PUBLISH'", "'AND'", "'OR'", 
		"'CONTAINS'", "'IS'", "'NOT'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "BOOLEAN_OPERATOR", "ARITHMETIC_SYMBOL", "WATCH", "WHERE", "PUBLISH", 
		"AND", "OR", "CONTAINS", "IS", "NOT", "PUBLISH_VALUE", "WEBSOCKETS", "TELEGRAM", 
		"DISCORD", "SLACK", "URL", "WORD", "DIGIT", "BYTECODE", "ADDRESS", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "DslGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static DslGrammarLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x17', '\xF5', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x3', '\x2', '\x3', '\x2', '\x5', '\x2', '\x30', 
		'\n', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x5', '\x3', '=', '\n', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x5', '\f', 'n', '\n', '\f', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x5', '\r', '\x98', '\n', '\r', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x5', '\xE', 
		'\xAA', '\n', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x5', '\xF', '\xBA', '\n', '\xF', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x5', '\x10', '\xC6', '\n', 
		'\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\a', '\x11', '\xD2', '\n', '\x11', '\f', '\x11', '\xE', '\x11', 
		'\xD5', '\v', '\x11', '\x3', '\x12', '\x6', '\x12', '\xD8', '\n', '\x12', 
		'\r', '\x12', '\xE', '\x12', '\xD9', '\x3', '\x13', '\x6', '\x13', '\xDD', 
		'\n', '\x13', '\r', '\x13', '\xE', '\x13', '\xDE', '\x3', '\x14', '\x6', 
		'\x14', '\xE2', '\n', '\x14', '\r', '\x14', '\xE', '\x14', '\xE3', '\x3', 
		'\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\a', '\x15', '\xEA', 
		'\n', '\x15', '\f', '\x15', '\xE', '\x15', '\xED', '\v', '\x15', '\x3', 
		'\x16', '\x6', '\x16', '\xF0', '\n', '\x16', '\r', '\x16', '\xE', '\x16', 
		'\xF1', '\x3', '\x16', '\x3', '\x16', '\x2', '\x2', '\x17', '\x3', '\x3', 
		'\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', 
		'\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', 
		'\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', 
		'\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '\x3', '\x2', 
		'\a', '\x4', '\x2', '>', '>', '@', '@', '\x4', '\x2', '\x43', '\\', '\x63', 
		'|', '\x3', '\x2', '\x32', ';', '\x5', '\x2', '\x32', ';', '\x43', 'H', 
		'\x63', 'h', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', 
		'\x10A', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', 
		')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '/', '\x3', '\x2', '\x2', '\x2', '\x5', '<', '\x3', '\x2', '\x2', 
		'\x2', '\a', '>', '\x3', '\x2', '\x2', '\x2', '\t', '\x44', '\x3', '\x2', 
		'\x2', '\x2', '\v', 'J', '\x3', '\x2', '\x2', '\x2', '\r', 'R', '\x3', 
		'\x2', '\x2', '\x2', '\xF', 'V', '\x3', '\x2', '\x2', '\x2', '\x11', 'Y', 
		'\x3', '\x2', '\x2', '\x2', '\x13', '\x62', '\x3', '\x2', '\x2', '\x2', 
		'\x15', '\x65', '\x3', '\x2', '\x2', '\x2', '\x17', 'm', '\x3', '\x2', 
		'\x2', '\x2', '\x19', '\x97', '\x3', '\x2', '\x2', '\x2', '\x1B', '\xA9', 
		'\x3', '\x2', '\x2', '\x2', '\x1D', '\xB9', '\x3', '\x2', '\x2', '\x2', 
		'\x1F', '\xC5', '\x3', '\x2', '\x2', '\x2', '!', '\xC7', '\x3', '\x2', 
		'\x2', '\x2', '#', '\xD7', '\x3', '\x2', '\x2', '\x2', '%', '\xDC', '\x3', 
		'\x2', '\x2', '\x2', '\'', '\xE1', '\x3', '\x2', '\x2', '\x2', ')', '\xE5', 
		'\x3', '\x2', '\x2', '\x2', '+', '\xEF', '\x3', '\x2', '\x2', '\x2', '-', 
		'\x30', '\x5', '\x5', '\x3', '\x2', '.', '\x30', '\x5', '\x11', '\t', 
		'\x2', '/', '-', '\x3', '\x2', '\x2', '\x2', '/', '.', '\x3', '\x2', '\x2', 
		'\x2', '\x30', '\x4', '\x3', '\x2', '\x2', '\x2', '\x31', '\x32', '\a', 
		'?', '\x2', '\x2', '\x32', '=', '\a', '?', '\x2', '\x2', '\x33', '\x34', 
		'\a', '#', '\x2', '\x2', '\x34', '=', '\a', '?', '\x2', '\x2', '\x35', 
		'=', '\t', '\x2', '\x2', '\x2', '\x36', '\x37', '\a', '>', '\x2', '\x2', 
		'\x37', '=', '\a', '?', '\x2', '\x2', '\x38', '\x39', '\a', '@', '\x2', 
		'\x2', '\x39', '=', '\a', '?', '\x2', '\x2', ':', '=', '\x5', '\x13', 
		'\n', '\x2', ';', '=', '\x5', '\x15', '\v', '\x2', '<', '\x31', '\x3', 
		'\x2', '\x2', '\x2', '<', '\x33', '\x3', '\x2', '\x2', '\x2', '<', '\x35', 
		'\x3', '\x2', '\x2', '\x2', '<', '\x36', '\x3', '\x2', '\x2', '\x2', '<', 
		'\x38', '\x3', '\x2', '\x2', '\x2', '<', ':', '\x3', '\x2', '\x2', '\x2', 
		'<', ';', '\x3', '\x2', '\x2', '\x2', '=', '\x6', '\x3', '\x2', '\x2', 
		'\x2', '>', '?', '\a', 'Y', '\x2', '\x2', '?', '@', '\a', '\x43', '\x2', 
		'\x2', '@', '\x41', '\a', 'V', '\x2', '\x2', '\x41', '\x42', '\a', '\x45', 
		'\x2', '\x2', '\x42', '\x43', '\a', 'J', '\x2', '\x2', '\x43', '\b', '\x3', 
		'\x2', '\x2', '\x2', '\x44', '\x45', '\a', 'Y', '\x2', '\x2', '\x45', 
		'\x46', '\a', 'J', '\x2', '\x2', '\x46', 'G', '\a', 'G', '\x2', '\x2', 
		'G', 'H', '\a', 'T', '\x2', '\x2', 'H', 'I', '\a', 'G', '\x2', '\x2', 
		'I', '\n', '\x3', '\x2', '\x2', '\x2', 'J', 'K', '\a', 'R', '\x2', '\x2', 
		'K', 'L', '\a', 'W', '\x2', '\x2', 'L', 'M', '\a', '\x44', '\x2', '\x2', 
		'M', 'N', '\a', 'N', '\x2', '\x2', 'N', 'O', '\a', 'K', '\x2', '\x2', 
		'O', 'P', '\a', 'U', '\x2', '\x2', 'P', 'Q', '\a', 'J', '\x2', '\x2', 
		'Q', '\f', '\x3', '\x2', '\x2', '\x2', 'R', 'S', '\a', '\x43', '\x2', 
		'\x2', 'S', 'T', '\a', 'P', '\x2', '\x2', 'T', 'U', '\a', '\x46', '\x2', 
		'\x2', 'U', '\xE', '\x3', '\x2', '\x2', '\x2', 'V', 'W', '\a', 'Q', '\x2', 
		'\x2', 'W', 'X', '\a', 'T', '\x2', '\x2', 'X', '\x10', '\x3', '\x2', '\x2', 
		'\x2', 'Y', 'Z', '\a', '\x45', '\x2', '\x2', 'Z', '[', '\a', 'Q', '\x2', 
		'\x2', '[', '\\', '\a', 'P', '\x2', '\x2', '\\', ']', '\a', 'V', '\x2', 
		'\x2', ']', '^', '\a', '\x43', '\x2', '\x2', '^', '_', '\a', 'K', '\x2', 
		'\x2', '_', '`', '\a', 'P', '\x2', '\x2', '`', '\x61', '\a', 'U', '\x2', 
		'\x2', '\x61', '\x12', '\x3', '\x2', '\x2', '\x2', '\x62', '\x63', '\a', 
		'K', '\x2', '\x2', '\x63', '\x64', '\a', 'U', '\x2', '\x2', '\x64', '\x14', 
		'\x3', '\x2', '\x2', '\x2', '\x65', '\x66', '\a', 'P', '\x2', '\x2', '\x66', 
		'g', '\a', 'Q', '\x2', '\x2', 'g', 'h', '\a', 'V', '\x2', '\x2', 'h', 
		'\x16', '\x3', '\x2', '\x2', '\x2', 'i', 'n', '\x5', '\x19', '\r', '\x2', 
		'j', 'n', '\x5', '\x1B', '\xE', '\x2', 'k', 'n', '\x5', '\x1D', '\xF', 
		'\x2', 'l', 'n', '\x5', '\x1F', '\x10', '\x2', 'm', 'i', '\x3', '\x2', 
		'\x2', '\x2', 'm', 'j', '\x3', '\x2', '\x2', '\x2', 'm', 'k', '\x3', '\x2', 
		'\x2', '\x2', 'm', 'l', '\x3', '\x2', '\x2', '\x2', 'n', '\x18', '\x3', 
		'\x2', '\x2', '\x2', 'o', 'p', '\a', 'Y', '\x2', '\x2', 'p', 'q', '\a', 
		'g', '\x2', '\x2', 'q', 'r', '\a', '\x64', '\x2', '\x2', 'r', 's', '\a', 
		'U', '\x2', '\x2', 's', 't', '\a', 'q', '\x2', '\x2', 't', 'u', '\a', 
		'\x65', '\x2', '\x2', 'u', 'v', '\a', 'm', '\x2', '\x2', 'v', 'w', '\a', 
		'g', '\x2', '\x2', 'w', 'x', '\a', 'v', '\x2', '\x2', 'x', '\x98', '\a', 
		'u', '\x2', '\x2', 'y', 'z', '\a', 'y', '\x2', '\x2', 'z', '{', '\a', 
		'g', '\x2', '\x2', '{', '|', '\a', '\x64', '\x2', '\x2', '|', '}', '\a', 
		'U', '\x2', '\x2', '}', '~', '\a', 'q', '\x2', '\x2', '~', '\x7F', '\a', 
		'\x65', '\x2', '\x2', '\x7F', '\x80', '\a', 'm', '\x2', '\x2', '\x80', 
		'\x81', '\a', 'g', '\x2', '\x2', '\x81', '\x82', '\a', 'v', '\x2', '\x2', 
		'\x82', '\x98', '\a', 'u', '\x2', '\x2', '\x83', '\x84', '\a', 'y', '\x2', 
		'\x2', '\x84', '\x85', '\a', 'g', '\x2', '\x2', '\x85', '\x86', '\a', 
		'\x64', '\x2', '\x2', '\x86', '\x87', '\a', 'u', '\x2', '\x2', '\x87', 
		'\x88', '\a', 'q', '\x2', '\x2', '\x88', '\x89', '\a', '\x65', '\x2', 
		'\x2', '\x89', '\x8A', '\a', 'm', '\x2', '\x2', '\x8A', '\x8B', '\a', 
		'g', '\x2', '\x2', '\x8B', '\x8C', '\a', 'v', '\x2', '\x2', '\x8C', '\x98', 
		'\a', 'u', '\x2', '\x2', '\x8D', '\x8E', '\a', 'Y', '\x2', '\x2', '\x8E', 
		'\x8F', '\a', 'g', '\x2', '\x2', '\x8F', '\x90', '\a', '\x64', '\x2', 
		'\x2', '\x90', '\x91', '\a', 'u', '\x2', '\x2', '\x91', '\x92', '\a', 
		'q', '\x2', '\x2', '\x92', '\x93', '\a', '\x65', '\x2', '\x2', '\x93', 
		'\x94', '\a', 'm', '\x2', '\x2', '\x94', '\x95', '\a', 'g', '\x2', '\x2', 
		'\x95', '\x96', '\a', 'v', '\x2', '\x2', '\x96', '\x98', '\a', 'u', '\x2', 
		'\x2', '\x97', 'o', '\x3', '\x2', '\x2', '\x2', '\x97', 'y', '\x3', '\x2', 
		'\x2', '\x2', '\x97', '\x83', '\x3', '\x2', '\x2', '\x2', '\x97', '\x8D', 
		'\x3', '\x2', '\x2', '\x2', '\x98', '\x1A', '\x3', '\x2', '\x2', '\x2', 
		'\x99', '\x9A', '\a', 'V', '\x2', '\x2', '\x9A', '\x9B', '\a', 'g', '\x2', 
		'\x2', '\x9B', '\x9C', '\a', 'n', '\x2', '\x2', '\x9C', '\x9D', '\a', 
		'g', '\x2', '\x2', '\x9D', '\x9E', '\a', 'i', '\x2', '\x2', '\x9E', '\x9F', 
		'\a', 't', '\x2', '\x2', '\x9F', '\xA0', '\a', '\x63', '\x2', '\x2', '\xA0', 
		'\xAA', '\a', 'o', '\x2', '\x2', '\xA1', '\xA2', '\a', 'v', '\x2', '\x2', 
		'\xA2', '\xA3', '\a', 'g', '\x2', '\x2', '\xA3', '\xA4', '\a', 'n', '\x2', 
		'\x2', '\xA4', '\xA5', '\a', 'g', '\x2', '\x2', '\xA5', '\xA6', '\a', 
		'i', '\x2', '\x2', '\xA6', '\xA7', '\a', 't', '\x2', '\x2', '\xA7', '\xA8', 
		'\a', '\x63', '\x2', '\x2', '\xA8', '\xAA', '\a', 'o', '\x2', '\x2', '\xA9', 
		'\x99', '\x3', '\x2', '\x2', '\x2', '\xA9', '\xA1', '\x3', '\x2', '\x2', 
		'\x2', '\xAA', '\x1C', '\x3', '\x2', '\x2', '\x2', '\xAB', '\xAC', '\a', 
		'\x46', '\x2', '\x2', '\xAC', '\xAD', '\a', 'k', '\x2', '\x2', '\xAD', 
		'\xAE', '\a', 'u', '\x2', '\x2', '\xAE', '\xAF', '\a', '\x65', '\x2', 
		'\x2', '\xAF', '\xB0', '\a', 'q', '\x2', '\x2', '\xB0', '\xB1', '\a', 
		't', '\x2', '\x2', '\xB1', '\xBA', '\a', '\x66', '\x2', '\x2', '\xB2', 
		'\xB3', '\a', '\x66', '\x2', '\x2', '\xB3', '\xB4', '\a', 'k', '\x2', 
		'\x2', '\xB4', '\xB5', '\a', 'u', '\x2', '\x2', '\xB5', '\xB6', '\a', 
		'\x65', '\x2', '\x2', '\xB6', '\xB7', '\a', 'q', '\x2', '\x2', '\xB7', 
		'\xB8', '\a', 't', '\x2', '\x2', '\xB8', '\xBA', '\a', '\x66', '\x2', 
		'\x2', '\xB9', '\xAB', '\x3', '\x2', '\x2', '\x2', '\xB9', '\xB2', '\x3', 
		'\x2', '\x2', '\x2', '\xBA', '\x1E', '\x3', '\x2', '\x2', '\x2', '\xBB', 
		'\xBC', '\a', 'U', '\x2', '\x2', '\xBC', '\xBD', '\a', 'n', '\x2', '\x2', 
		'\xBD', '\xBE', '\a', '\x63', '\x2', '\x2', '\xBE', '\xBF', '\a', '\x65', 
		'\x2', '\x2', '\xBF', '\xC6', '\a', 'm', '\x2', '\x2', '\xC0', '\xC1', 
		'\a', 'u', '\x2', '\x2', '\xC1', '\xC2', '\a', 'n', '\x2', '\x2', '\xC2', 
		'\xC3', '\a', '\x63', '\x2', '\x2', '\xC3', '\xC4', '\a', '\x65', '\x2', 
		'\x2', '\xC4', '\xC6', '\a', 'm', '\x2', '\x2', '\xC5', '\xBB', '\x3', 
		'\x2', '\x2', '\x2', '\xC5', '\xC0', '\x3', '\x2', '\x2', '\x2', '\xC6', 
		' ', '\x3', '\x2', '\x2', '\x2', '\xC7', '\xC8', '\a', 'j', '\x2', '\x2', 
		'\xC8', '\xC9', '\a', 'v', '\x2', '\x2', '\xC9', '\xCA', '\a', 'v', '\x2', 
		'\x2', '\xCA', '\xCB', '\a', 'r', '\x2', '\x2', '\xCB', '\xCC', '\a', 
		'u', '\x2', '\x2', '\xCC', '\xCD', '\a', '<', '\x2', '\x2', '\xCD', '\xCE', 
		'\a', '\x31', '\x2', '\x2', '\xCE', '\xCF', '\a', '\x31', '\x2', '\x2', 
		'\xCF', '\xD3', '\x3', '\x2', '\x2', '\x2', '\xD0', '\xD2', '\v', '\x2', 
		'\x2', '\x2', '\xD1', '\xD0', '\x3', '\x2', '\x2', '\x2', '\xD2', '\xD5', 
		'\x3', '\x2', '\x2', '\x2', '\xD3', '\xD1', '\x3', '\x2', '\x2', '\x2', 
		'\xD3', '\xD4', '\x3', '\x2', '\x2', '\x2', '\xD4', '\"', '\x3', '\x2', 
		'\x2', '\x2', '\xD5', '\xD3', '\x3', '\x2', '\x2', '\x2', '\xD6', '\xD8', 
		'\t', '\x3', '\x2', '\x2', '\xD7', '\xD6', '\x3', '\x2', '\x2', '\x2', 
		'\xD8', '\xD9', '\x3', '\x2', '\x2', '\x2', '\xD9', '\xD7', '\x3', '\x2', 
		'\x2', '\x2', '\xD9', '\xDA', '\x3', '\x2', '\x2', '\x2', '\xDA', '$', 
		'\x3', '\x2', '\x2', '\x2', '\xDB', '\xDD', '\t', '\x4', '\x2', '\x2', 
		'\xDC', '\xDB', '\x3', '\x2', '\x2', '\x2', '\xDD', '\xDE', '\x3', '\x2', 
		'\x2', '\x2', '\xDE', '\xDC', '\x3', '\x2', '\x2', '\x2', '\xDE', '\xDF', 
		'\x3', '\x2', '\x2', '\x2', '\xDF', '&', '\x3', '\x2', '\x2', '\x2', '\xE0', 
		'\xE2', '\t', '\x5', '\x2', '\x2', '\xE1', '\xE0', '\x3', '\x2', '\x2', 
		'\x2', '\xE2', '\xE3', '\x3', '\x2', '\x2', '\x2', '\xE3', '\xE1', '\x3', 
		'\x2', '\x2', '\x2', '\xE3', '\xE4', '\x3', '\x2', '\x2', '\x2', '\xE4', 
		'(', '\x3', '\x2', '\x2', '\x2', '\xE5', '\xE6', '\a', '\x32', '\x2', 
		'\x2', '\xE6', '\xE7', '\a', 'z', '\x2', '\x2', '\xE7', '\xEB', '\x3', 
		'\x2', '\x2', '\x2', '\xE8', '\xEA', '\t', '\x5', '\x2', '\x2', '\xE9', 
		'\xE8', '\x3', '\x2', '\x2', '\x2', '\xEA', '\xED', '\x3', '\x2', '\x2', 
		'\x2', '\xEB', '\xE9', '\x3', '\x2', '\x2', '\x2', '\xEB', '\xEC', '\x3', 
		'\x2', '\x2', '\x2', '\xEC', '*', '\x3', '\x2', '\x2', '\x2', '\xED', 
		'\xEB', '\x3', '\x2', '\x2', '\x2', '\xEE', '\xF0', '\t', '\x6', '\x2', 
		'\x2', '\xEF', '\xEE', '\x3', '\x2', '\x2', '\x2', '\xF0', '\xF1', '\x3', 
		'\x2', '\x2', '\x2', '\xF1', '\xEF', '\x3', '\x2', '\x2', '\x2', '\xF1', 
		'\xF2', '\x3', '\x2', '\x2', '\x2', '\xF2', '\xF3', '\x3', '\x2', '\x2', 
		'\x2', '\xF3', '\xF4', '\b', '\x16', '\x2', '\x2', '\xF4', ',', '\x3', 
		'\x2', '\x2', '\x2', '\x10', '\x2', '/', '<', 'm', '\x97', '\xA9', '\xB9', 
		'\xC5', '\xD3', '\xD9', '\xDE', '\xE3', '\xEB', '\xF1', '\x3', '\b', '\x2', 
		'\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
