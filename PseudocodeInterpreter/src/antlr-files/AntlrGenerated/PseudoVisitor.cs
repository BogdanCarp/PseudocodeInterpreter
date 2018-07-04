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

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="PseudoParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public interface IPseudoVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFile([NotNull] PseudoParser.FileContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.statList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatList([NotNull] PseudoParser.StatListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStat([NotNull] PseudoParser.StatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.ifStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStat([NotNull] PseudoParser.IfStatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.elseIfStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseIfStat([NotNull] PseudoParser.ElseIfStatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.elseStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseStat([NotNull] PseudoParser.ElseStatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.readBuiltin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReadBuiltin([NotNull] PseudoParser.ReadBuiltinContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.writeBuiltin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWriteBuiltin([NotNull] PseudoParser.WriteBuiltinContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VariableDeclaration</c>
	/// labeled alternative in <see cref="PseudoParser.varDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclaration([NotNull] PseudoParser.VariableDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.optionalAssign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOptionalAssign([NotNull] PseudoParser.OptionalAssignContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VariableAssignment</c>
	/// labeled alternative in <see cref="PseudoParser.varAssign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableAssignment([NotNull] PseudoParser.VariableAssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="PseudoParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] PseudoParser.TypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LessOrEqual</c>
	/// labeled alternative in <see cref="PseudoParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLessOrEqual([NotNull] PseudoParser.LessOrEqualContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>OrOp</c>
	/// labeled alternative in <see cref="PseudoParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrOp([NotNull] PseudoParser.OrOpContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LessThan</c>
	/// labeled alternative in <see cref="PseudoParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLessThan([NotNull] PseudoParser.LessThanContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>GreaterThan</c>
	/// labeled alternative in <see cref="PseudoParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGreaterThan([NotNull] PseudoParser.GreaterThanContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>GreaterOrEqual</c>
	/// labeled alternative in <see cref="PseudoParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGreaterOrEqual([NotNull] PseudoParser.GreaterOrEqualContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AreEqual</c>
	/// labeled alternative in <see cref="PseudoParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAreEqual([NotNull] PseudoParser.AreEqualContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AndOp</c>
	/// labeled alternative in <see cref="PseudoParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAndOp([NotNull] PseudoParser.AndOpContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ToPlusOrMinus</c>
	/// labeled alternative in <see cref="PseudoParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitToPlusOrMinus([NotNull] PseudoParser.ToPlusOrMinusContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="PseudoParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] PseudoParser.StringContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Add</c>
	/// labeled alternative in <see cref="PseudoParser.plusOrMinus"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdd([NotNull] PseudoParser.AddContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ToMultOrDiv</c>
	/// labeled alternative in <see cref="PseudoParser.plusOrMinus"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitToMultOrDiv([NotNull] PseudoParser.ToMultOrDivContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Sub</c>
	/// labeled alternative in <see cref="PseudoParser.plusOrMinus"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSub([NotNull] PseudoParser.SubContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Div</c>
	/// labeled alternative in <see cref="PseudoParser.multOrDiv"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDiv([NotNull] PseudoParser.DivContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ToUnarySign</c>
	/// labeled alternative in <see cref="PseudoParser.multOrDiv"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitToUnarySign([NotNull] PseudoParser.ToUnarySignContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Mult</c>
	/// labeled alternative in <see cref="PseudoParser.multOrDiv"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMult([NotNull] PseudoParser.MultContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>UnaryPlus</c>
	/// labeled alternative in <see cref="PseudoParser.unarySign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryPlus([NotNull] PseudoParser.UnaryPlusContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>UnaryMinus</c>
	/// labeled alternative in <see cref="PseudoParser.unarySign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryMinus([NotNull] PseudoParser.UnaryMinusContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ToAtom</c>
	/// labeled alternative in <see cref="PseudoParser.unarySign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitToAtom([NotNull] PseudoParser.ToAtomContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Integer</c>
	/// labeled alternative in <see cref="PseudoParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInteger([NotNull] PseudoParser.IntegerContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FloatingPoint</c>
	/// labeled alternative in <see cref="PseudoParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFloatingPoint([NotNull] PseudoParser.FloatingPointContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>GetVariable</c>
	/// labeled alternative in <see cref="PseudoParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGetVariable([NotNull] PseudoParser.GetVariableContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ToParenPlusOrMinus</c>
	/// labeled alternative in <see cref="PseudoParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitToParenPlusOrMinus([NotNull] PseudoParser.ToParenPlusOrMinusContext context);
}
} // namespace AntlrGenerated
