using Godot;
using System;

public partial class CardState : Node
{
    [Export] public State state;
    [Signal] public delegate void TransitionRequested(State from, State to);

    public CardUi cardUi;

    public void Enter()
    {
        
    }

    public void Exit()
    {
        
    }

    public void OnInput(InputEvent inputEvent)
    {
        
    }

    public void OnGuiInput(InputEvent inputEvent)
    {
        
    }

    public void OnMouseEntered()
    {
        
    }

    public void OnMouseExited()
    {
        
    }
}

public enum State {BASE, CLICKED, DRAGGING, AIMING, RELEASED}