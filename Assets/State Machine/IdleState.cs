using UnityEngine;

public class IdleState : State
{
    private Player _player;
    public IdleState(Player player)
    {
        _player = player;
    }
    
    public override void Enter()
    {
        base.Enter();
        Debug.Log("I entered in Idle state");
        _player.animation.Play("idle");
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("I came out of my Idle state");
    }
}
