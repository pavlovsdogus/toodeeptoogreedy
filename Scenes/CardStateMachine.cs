using Godot;
using System;
using System.Collections.Generic;

public partial class CardStateMachine : Node
{
    [Export] private CardState _initialCardState;

    private CardState _currentState;
    private Dictionary<CardState, Node> _states = new();

    private void Init(CardUi cardUi)
    {
        foreach (var child in GetChildren())
        {
            if (child is CardState state)
            {
                _states[state] = child;
                _currentState = state;
                child.TransitionRequested.Connect(OnTransitionRequested);
                state.cardUi = cardUi;
            }
        }

        if (_initialCardState != null)
        {
            _initialCardState.Enter();
            _currentState = _initialCardState;
        }
    }

    private void OnInput(InputEvent inputEvent)
    {
        if (_currentState != null)
        {
            _currentState.OnInput(inputEvent);
        }
    }

    private void OnGUIInput(InputEvent inputEvent)
    {
        if (_currentState != null)
        {
            _currentState.OnGuiInput(inputEvent);
        }
    }

    private void OnMouseEntered()
    {
        if (_currentState != null)
        {
            _currentState.OnMouseEntered();
        }
    }

    private void OnMouseExited()
    {
        if (_currentState != null)
        {
            _currentState.OnMouseExited();
        }
    }

    private void OnTransitionRequested(CardState from, State to)
    {
        if(from != _currentState) return;
        
    }
}
