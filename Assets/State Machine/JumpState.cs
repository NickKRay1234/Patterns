using UnityEngine;

public class JumpState : State
{
    private Player _player;

    public JumpState(Player player)
    {
        _player = player;
    }
    
    public override void Enter()
    {
        base.Enter();
        Debug.Log("I entered in Jump state");
        _player.animation.Play("jump");
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("I came out of my Jump state");
    }
}
