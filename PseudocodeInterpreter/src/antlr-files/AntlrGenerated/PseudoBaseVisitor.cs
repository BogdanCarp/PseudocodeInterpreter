//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/Sergiu/RiderProjects/PseudocodeInterpreter/PseudocodeInterpreter/src/antlr-files\Pseudo.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AntlrGenerated {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IPseudoVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class PseudoBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IPseudoVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.file"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFile([NotNull] PseudoParser.FileContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.statList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStatList([NotNull] PseudoParser.StatListContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.stat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStat([NotNull] PseudoParser.StatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.ifStat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIfStat([NotNull] PseudoParser.IfStatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.elseIfStat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitElseIfStat([NotNull] PseudoParser.ElseIfStatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.elseStat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitElseStat([NotNull] PseudoParser.ElseStatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.readBuiltin"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitReadBuiltin([NotNull] PseudoParser.ReadBuiltinContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.writeBuiltin"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWriteBuiltin([NotNull] PseudoParser.WriteBuiltinContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>VariableDeclaration</c>
	/// labeled alternative in <see cref="PseudoParser.varDecl"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitVariableDeclaration([NotNull] PseudoParser.VariableDeclarationContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.optionalAssign"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOptionalAssign([NotNull] PseudoParser.OptionalAssignContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>VariableAssignment</c>
	/// labeled alternative in <see cref="PseudoParser.varAssign"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitVariableAssignment([NotNull] PseudoParser.VariableAssignmentContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.type"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitType([NotNull] PseudoParser.TypeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>LessOrEqual</c>
	/// labeled alternative in <see cref="PseudoParser.boolOp"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLessOrEqual([NotNull] PseudoParser.LessOrEqualContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>OrOp</c>
	/// labeled alternative in <see cref="PseudoParser.boolOp"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOrOp([NotNull] PseudoParser.OrOpContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>LessThan</c>
	/// labeled alternative in <see cref="PseudoParser.boolOp"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLessThan([NotNull] PseudoParser.LessThanContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>GreaterThan</c>
	/// labeled alternative in <see cref="PseudoParser.boolOp"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitGreaterThan([NotNull] PseudoParser.GreaterThanContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>GreaterOrEqual</c>
	/// labeled alternative in <see cref="PseudoParser.boolOp"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitGreaterOrEqual([NotNull] PseudoParser.GreaterOrEqualContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>AreEqual</c>
	/// labeled alternative in <see cref="PseudoParser.boolOp"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAreEqual([NotNull] PseudoParser.AreEqualContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>AndOp</c>
	/// labeled alternative in <see cref="PseudoParser.boolOp"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAndOp([NotNull] PseudoParser.AndOpContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>ToPlusOrMinus</c>
	/// labeled alternative in <see cref="PseudoParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitToPlusOrMinus([NotNull] PseudoParser.ToPlusOrMinusContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="PseudoParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitString([NotNull] PseudoParser.StringContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>Add</c>
	/// labeled alternative in <see cref="PseudoParser.plusOrMinus"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAdd([NotNull] PseudoParser.AddContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>ToMultOrDiv</c>
	/// labeled alternative in <see cref="PseudoParser.plusOrMinus"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitToMultOrDiv([NotNull] PseudoParser.ToMultOrDivContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>Sub</c>
	/// labeled alternative in <see cref="PseudoParser.plusOrMinus"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSub([NotNull] PseudoParser.SubContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>Div</c>
	/// labeled alternative in <see cref="PseudoParser.multOrDiv"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDiv([NotNull] PseudoParser.DivContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>ToUnarySign</c>
	/// labeled alternative in <see cref="PseudoParser.multOrDiv"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitToUnarySign([NotNull] PseudoParser.ToUnarySignContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>Mult</c>
	/// labeled alternative in <see cref="PseudoParser.multOrDiv"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMult([NotNull] PseudoParser.MultContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>UnaryPlus</c>
	/// labeled alternative in <see cref="PseudoParser.unarySign"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitUnaryPlus([NotNull] PseudoParser.UnaryPlusContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>UnaryMinus</c>
	/// labeled alternative in <see cref="PseudoParser.unarySign"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitUnaryMinus([NotNull] PseudoParser.UnaryMinusContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>ToAtom</c>
	/// labeled alternative in <see cref="PseudoParser.unarySign"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitToAtom([NotNull] PseudoParser.ToAtomContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>Integer</c>
	/// labeled alternative in <see cref="PseudoParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInteger([NotNull] PseudoParser.IntegerContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>FloatingPoint</c>
	/// labeled alternative in <see cref="PseudoParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFloatingPoint([NotNull] PseudoParser.FloatingPointContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>GetVariable</c>
	/// labeled alternative in <see cref="PseudoParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitGetVariable([NotNull] PseudoParser.GetVariableContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>ToParenPlusOrMinus</c>
	/// labeled alternative in <see cref="PseudoParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitToParenPlusOrMinus([NotNull] PseudoParser.ToParenPlusOrMinusContext context) { return VisitChildren(context); }
}
} // namespace AntlrGenerated
