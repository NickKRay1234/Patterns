using UnityEngine;

public class IdleState : State
{
    public override void Enter()
    {
        base.Enter();
        Debug.Log("I entered in Idle state");
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("I came out of my Idle state");
    }
}
