using UnityEngine;

public class JumpState : State
{
    public override void Enter()
    {
        base.Enter();
        Debug.Log("I entered in Jump state");
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("I came out of my Jump state");
    }
}
