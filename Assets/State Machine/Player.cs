using UnityEngine;

public class Player : MonoBehaviour
{
    private StateMachine _stateMachine;
    private RunState _runState;

    private void Start()
    {
        _stateMachine = new StateMachine();
        _stateMachine.Initialize(new IdleState());
    }

    private void Update()
    {
        _stateMachine.CurrentState.Update();
        
        if(Input.GetKeyDown(KeyCode.R)) _stateMachine.ChangeState(new RunState());
        if(Input.GetKeyDown(KeyCode.I)) _stateMachine.ChangeState(new IdleState());
        if(Input.GetKeyDown(KeyCode.J)) _stateMachine.ChangeState(new JumpState());
    }
    
    
}
