using UnityEngine;

public class EntityStateManager : MonoBehaviour
{
    public Mediator mediator;
    
    private EntityBaseState _currentState;
    public StandState standState = new();
    public MoveState moveState = new();
    public RotationState rotationState = new();

    void Start()
    {
        // Starting state from the state machine
        _currentState = standState;
        _currentState.EnterState(this);
    }

    void Update()
    {
        _currentState.UpdateState(this);
    }

    public void SwitchState(EntityBaseState state)
    {
        _currentState = state;
        _currentState.EnterState(this);
    }
}
