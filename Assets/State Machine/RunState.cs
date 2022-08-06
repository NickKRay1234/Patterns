using UnityEngine;

public class RunState : State
{
    public override void Enter()
    {
        base.Enter();
        Debug.Log("I entered in Run state");
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("I came out of my Run state");
    }

    public override void Update()
    {
        base.Update();
        Debug.Log("I'm in Run state");
    }
}
