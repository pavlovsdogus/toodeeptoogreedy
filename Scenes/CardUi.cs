using Godot;
using System;

public partial class CardUi : Control
{
	[Signal] public delegate void ReparentRequested(CardUi cardUi);

	private ColorRect _colorRect;
	private Label _stateLabel;
	public override void _Ready()
	{
		_colorRect = GetNode<ColorRect>("Color");
		_stateLabel = GetNode<Label>("State");
	}
}
