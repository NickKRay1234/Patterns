using UnityEngine;

public class RunState : State
{
    private Player _player;

    public RunState(Player player)
    {
        _player = player;
    }
    
    public override void Enter()
    {
        base.Enter();
        Debug.Log("I entered in Run state");
        //_player.animation();
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
        _player.transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y,
            _player.transform.position.z + 100 * Time.deltaTime);
    }
}
