using UnityEngine;

public class Player : MonoBehaviour
{
    private StateMachine _stateMachine;
    private RunState _runState;
    private IdleState _idleState;
    private JumpState _jumpState;
    public Animation animation;

    private void Start()
    {
        _stateMachine = new StateMachine();
        _runState = new RunState(this);
        _idleState = new IdleState(this);
        _jumpState = new JumpState(this);
        _stateMachine.Initialize(_idleState);
    }

    private void Update()
    {
        _stateMachine.CurrentState.Update();
        
        if(Input.GetKeyDown(KeyCode.R)) _stateMachine.ChangeState(_runState);
        if(Input.GetKeyDown(KeyCode.I)) _stateMachine.ChangeState(_idleState);
        if(Input.GetKeyDown(KeyCode.J)) _stateMachine.ChangeState(_jumpState);
    }
    
    
}
