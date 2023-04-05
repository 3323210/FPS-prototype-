using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMashina
{
    public State CurrenState { get; set; }
   public void Initialize(State startState)
    {
        CurrenState = startState;
        CurrenState.Enter();
    }
    public void ChangeState(State newState)
    {
        CurrenState.Exit();
        CurrenState = newState;
        CurrenState.Enter();
    }
}
