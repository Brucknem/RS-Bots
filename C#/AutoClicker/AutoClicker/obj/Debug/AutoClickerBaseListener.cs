//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Marcel Bruckner\Documents\RS-Bots\C#\AutoClicker\AutoClicker\InstructionsParser\AutoClicker.g4 by ANTLR 4.6.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AutoClicker {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IAutoClickerListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.1")]
[System.CLSCompliant(false)]
public partial class AutoClickerBaseListener : IAutoClickerListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.intTuple"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIntTuple([NotNull] AutoClickerParser.IntTupleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.intTuple"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIntTuple([NotNull] AutoClickerParser.IntTupleContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.doubleTuple"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDoubleTuple([NotNull] AutoClickerParser.DoubleTupleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.doubleTuple"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDoubleTuple([NotNull] AutoClickerParser.DoubleTupleContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.trueFalse"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTrueFalse([NotNull] AutoClickerParser.TrueFalseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.trueFalse"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTrueFalse([NotNull] AutoClickerParser.TrueFalseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.instructions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInstructions([NotNull] AutoClickerParser.InstructionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.instructions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInstructions([NotNull] AutoClickerParser.InstructionsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.instruction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInstruction([NotNull] AutoClickerParser.InstructionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.instruction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInstruction([NotNull] AutoClickerParser.InstructionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.commons"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommons([NotNull] AutoClickerParser.CommonsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.commons"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommons([NotNull] AutoClickerParser.CommonsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.delay"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDelay([NotNull] AutoClickerParser.DelayContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.delay"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDelay([NotNull] AutoClickerParser.DelayContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.repetitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRepetitions([NotNull] AutoClickerParser.RepetitionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.repetitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRepetitions([NotNull] AutoClickerParser.RepetitionsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.speed"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSpeed([NotNull] AutoClickerParser.SpeedContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.speed"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSpeed([NotNull] AutoClickerParser.SpeedContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.shift"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShift([NotNull] AutoClickerParser.ShiftContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.shift"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShift([NotNull] AutoClickerParser.ShiftContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.ctrl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCtrl([NotNull] AutoClickerParser.CtrlContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.ctrl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCtrl([NotNull] AutoClickerParser.CtrlContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.alt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlt([NotNull] AutoClickerParser.AltContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.alt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlt([NotNull] AutoClickerParser.AltContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.hover"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHover([NotNull] AutoClickerParser.HoverContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.hover"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHover([NotNull] AutoClickerParser.HoverContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.click"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClick([NotNull] AutoClickerParser.ClickContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.click"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClick([NotNull] AutoClickerParser.ClickContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.drag"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrag([NotNull] AutoClickerParser.DragContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.drag"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrag([NotNull] AutoClickerParser.DragContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.xPos"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXPos([NotNull] AutoClickerParser.XPosContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.xPos"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXPos([NotNull] AutoClickerParser.XPosContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.yPos"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterYPos([NotNull] AutoClickerParser.YPosContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.yPos"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitYPos([NotNull] AutoClickerParser.YPosContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.endX"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEndX([NotNull] AutoClickerParser.EndXContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.endX"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEndX([NotNull] AutoClickerParser.EndXContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.endY"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEndY([NotNull] AutoClickerParser.EndYContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.endY"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEndY([NotNull] AutoClickerParser.EndYContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.button"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterButton([NotNull] AutoClickerParser.ButtonContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.button"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitButton([NotNull] AutoClickerParser.ButtonContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.movement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMovement([NotNull] AutoClickerParser.MovementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.movement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMovement([NotNull] AutoClickerParser.MovementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.keyInput"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyInput([NotNull] AutoClickerParser.KeyInputContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.keyInput"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyInput([NotNull] AutoClickerParser.KeyInputContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.keystroke"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeystroke([NotNull] AutoClickerParser.KeystrokeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.keystroke"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeystroke([NotNull] AutoClickerParser.KeystrokeContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.stringInput"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStringInput([NotNull] AutoClickerParser.StringInputContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.stringInput"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStringInput([NotNull] AutoClickerParser.StringInputContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AutoClickerParser.text"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterText([NotNull] AutoClickerParser.TextContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutoClickerParser.text"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitText([NotNull] AutoClickerParser.TextContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace AutoClicker
