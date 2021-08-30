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
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class DslGrammarParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		BOOLEAN_OPERATOR=1, ARITHMETIC_SYMBOL=2, WATCH=3, WHERE=4, PUBLISH=5, 
		AND=6, OR=7, CONTAINS=8, IS=9, NOT=10, PUBLISH_VALUE=11, WEBSOCKETS=12, 
		TELEGRAM=13, DISCORD=14, SLACK=15, URL=16, WORD=17, DIGIT=18, BYTECODE=19, 
		ADDRESS=20, WS=21;
	public const int
		RULE_tree = 0, RULE_expression = 1, RULE_watchExpression = 2, RULE_whereExpression = 3, 
		RULE_publishExpression = 4, RULE_condition = 5, RULE_andCondition = 6, 
		RULE_orCondition = 7;
	public static readonly string[] ruleNames = {
		"tree", "expression", "watchExpression", "whereExpression", "publishExpression", 
		"condition", "andCondition", "orCondition"
	};

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

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static DslGrammarParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public DslGrammarParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public DslGrammarParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class TreeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public TreeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tree; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.EnterTree(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.ExitTree(this);
		}
	}

	[RuleVersion(0)]
	public TreeContext tree() {
		TreeContext _localctx = new TreeContext(Context, State);
		EnterRule(_localctx, 0, RULE_tree);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 19;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << WATCH) | (1L << WHERE) | (1L << PUBLISH) | (1L << AND) | (1L << OR))) != 0)) {
				{
				{
				State = 16;
				expression();
				}
				}
				State = 21;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public WatchExpressionContext watchExpression() {
			return GetRuleContext<WatchExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public WhereExpressionContext whereExpression() {
			return GetRuleContext<WhereExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PublishExpressionContext publishExpression() {
			return GetRuleContext<PublishExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AndConditionContext andCondition() {
			return GetRuleContext<AndConditionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public OrConditionContext orCondition() {
			return GetRuleContext<OrConditionContext>(0);
		}
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.EnterExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.ExitExpression(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		ExpressionContext _localctx = new ExpressionContext(Context, State);
		EnterRule(_localctx, 2, RULE_expression);
		try {
			State = 27;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case WATCH:
				EnterOuterAlt(_localctx, 1);
				{
				State = 22;
				watchExpression();
				}
				break;
			case WHERE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 23;
				whereExpression();
				}
				break;
			case PUBLISH:
				EnterOuterAlt(_localctx, 3);
				{
				State = 24;
				publishExpression();
				}
				break;
			case AND:
				EnterOuterAlt(_localctx, 4);
				{
				State = 25;
				andCondition();
				}
				break;
			case OR:
				EnterOuterAlt(_localctx, 5);
				{
				State = 26;
				orCondition();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WatchExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WATCH() { return GetToken(DslGrammarParser.WATCH, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WORD() { return GetToken(DslGrammarParser.WORD, 0); }
		public WatchExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_watchExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.EnterWatchExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.ExitWatchExpression(this);
		}
	}

	[RuleVersion(0)]
	public WatchExpressionContext watchExpression() {
		WatchExpressionContext _localctx = new WatchExpressionContext(Context, State);
		EnterRule(_localctx, 4, RULE_watchExpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 29;
			Match(WATCH);
			State = 30;
			Match(WORD);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WhereExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHERE() { return GetToken(DslGrammarParser.WHERE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConditionContext condition() {
			return GetRuleContext<ConditionContext>(0);
		}
		public WhereExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_whereExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.EnterWhereExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.ExitWhereExpression(this);
		}
	}

	[RuleVersion(0)]
	public WhereExpressionContext whereExpression() {
		WhereExpressionContext _localctx = new WhereExpressionContext(Context, State);
		EnterRule(_localctx, 6, RULE_whereExpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 32;
			Match(WHERE);
			State = 33;
			condition();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PublishExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLISH() { return GetToken(DslGrammarParser.PUBLISH, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLISH_VALUE() { return GetToken(DslGrammarParser.PUBLISH_VALUE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode URL() { return GetToken(DslGrammarParser.URL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WORD() { return GetToken(DslGrammarParser.WORD, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIGIT() { return GetToken(DslGrammarParser.DIGIT, 0); }
		public PublishExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_publishExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.EnterPublishExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.ExitPublishExpression(this);
		}
	}

	[RuleVersion(0)]
	public PublishExpressionContext publishExpression() {
		PublishExpressionContext _localctx = new PublishExpressionContext(Context, State);
		EnterRule(_localctx, 8, RULE_publishExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 35;
			Match(PUBLISH);
			State = 36;
			Match(PUBLISH_VALUE);
			State = 37;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << URL) | (1L << WORD) | (1L << DIGIT))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ConditionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] WORD() { return GetTokens(DslGrammarParser.WORD); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WORD(int i) {
			return GetToken(DslGrammarParser.WORD, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BOOLEAN_OPERATOR() { return GetToken(DslGrammarParser.BOOLEAN_OPERATOR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIGIT() { return GetToken(DslGrammarParser.DIGIT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ADDRESS() { return GetToken(DslGrammarParser.ADDRESS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BYTECODE() { return GetToken(DslGrammarParser.BYTECODE, 0); }
		public ConditionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_condition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.EnterCondition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.ExitCondition(this);
		}
	}

	[RuleVersion(0)]
	public ConditionContext condition() {
		ConditionContext _localctx = new ConditionContext(Context, State);
		EnterRule(_localctx, 10, RULE_condition);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 39;
			Match(WORD);
			State = 40;
			Match(BOOLEAN_OPERATOR);
			State = 41;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << WORD) | (1L << DIGIT) | (1L << BYTECODE) | (1L << ADDRESS))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AndConditionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AND() { return GetToken(DslGrammarParser.AND, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConditionContext condition() {
			return GetRuleContext<ConditionContext>(0);
		}
		public AndConditionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_andCondition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.EnterAndCondition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.ExitAndCondition(this);
		}
	}

	[RuleVersion(0)]
	public AndConditionContext andCondition() {
		AndConditionContext _localctx = new AndConditionContext(Context, State);
		EnterRule(_localctx, 12, RULE_andCondition);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 43;
			Match(AND);
			State = 44;
			condition();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OrConditionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OR() { return GetToken(DslGrammarParser.OR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConditionContext condition() {
			return GetRuleContext<ConditionContext>(0);
		}
		public OrConditionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_orCondition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.EnterOrCondition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.ExitOrCondition(this);
		}
	}

	[RuleVersion(0)]
	public OrConditionContext orCondition() {
		OrConditionContext _localctx = new OrConditionContext(Context, State);
		EnterRule(_localctx, 14, RULE_orCondition);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 46;
			Match(OR);
			State = 47;
			condition();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x17', '\x34', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x3', '\x2', '\a', '\x2', '\x14', '\n', '\x2', 
		'\f', '\x2', '\xE', '\x2', '\x17', '\v', '\x2', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x5', '\x3', '\x1E', '\n', 
		'\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x2', '\x2', '\n', '\x2', '\x4', '\x6', '\b', '\n', '\f', '\xE', 
		'\x10', '\x2', '\x4', '\x3', '\x2', '\x12', '\x14', '\x3', '\x2', '\x13', 
		'\x16', '\x2', '\x30', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x4', 
		'\x1D', '\x3', '\x2', '\x2', '\x2', '\x6', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '\b', '\"', '\x3', '\x2', '\x2', '\x2', '\n', '%', '\x3', '\x2', 
		'\x2', '\x2', '\f', ')', '\x3', '\x2', '\x2', '\x2', '\xE', '-', '\x3', 
		'\x2', '\x2', '\x2', '\x10', '\x30', '\x3', '\x2', '\x2', '\x2', '\x12', 
		'\x14', '\x5', '\x4', '\x3', '\x2', '\x13', '\x12', '\x3', '\x2', '\x2', 
		'\x2', '\x14', '\x17', '\x3', '\x2', '\x2', '\x2', '\x15', '\x13', '\x3', 
		'\x2', '\x2', '\x2', '\x15', '\x16', '\x3', '\x2', '\x2', '\x2', '\x16', 
		'\x3', '\x3', '\x2', '\x2', '\x2', '\x17', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\x18', '\x1E', '\x5', '\x6', '\x4', '\x2', '\x19', '\x1E', '\x5', 
		'\b', '\x5', '\x2', '\x1A', '\x1E', '\x5', '\n', '\x6', '\x2', '\x1B', 
		'\x1E', '\x5', '\xE', '\b', '\x2', '\x1C', '\x1E', '\x5', '\x10', '\t', 
		'\x2', '\x1D', '\x18', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x19', '\x3', 
		'\x2', '\x2', '\x2', '\x1D', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'\x1B', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', '\x1E', '\x5', '\x3', '\x2', '\x2', '\x2', '\x1F', ' ', '\a', '\x5', 
		'\x2', '\x2', ' ', '!', '\a', '\x13', '\x2', '\x2', '!', '\a', '\x3', 
		'\x2', '\x2', '\x2', '\"', '#', '\a', '\x6', '\x2', '\x2', '#', '$', '\x5', 
		'\f', '\a', '\x2', '$', '\t', '\x3', '\x2', '\x2', '\x2', '%', '&', '\a', 
		'\a', '\x2', '\x2', '&', '\'', '\a', '\r', '\x2', '\x2', '\'', '(', '\t', 
		'\x2', '\x2', '\x2', '(', '\v', '\x3', '\x2', '\x2', '\x2', ')', '*', 
		'\a', '\x13', '\x2', '\x2', '*', '+', '\a', '\x3', '\x2', '\x2', '+', 
		',', '\t', '\x3', '\x2', '\x2', ',', '\r', '\x3', '\x2', '\x2', '\x2', 
		'-', '.', '\a', '\b', '\x2', '\x2', '.', '/', '\x5', '\f', '\a', '\x2', 
		'/', '\xF', '\x3', '\x2', '\x2', '\x2', '\x30', '\x31', '\a', '\t', '\x2', 
		'\x2', '\x31', '\x32', '\x5', '\f', '\a', '\x2', '\x32', '\x11', '\x3', 
		'\x2', '\x2', '\x2', '\x4', '\x15', '\x1D',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
