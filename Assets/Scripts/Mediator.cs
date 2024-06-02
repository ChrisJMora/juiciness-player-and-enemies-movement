using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Mediator : MonoBehaviour
{
    public EntityData data;
    public EntityStateManager stateManager;
    public Animator animator;

    [Header("Components")]
    public InputComponent inputComponent;
    public RotationComponent rotationComponent;
    public MovementComponent movementComponent;
    
    private void Start()
    {
        inputComponent = new InputComponent();
        movementComponent = new MovementComponent()
        {
            Speed = 0,
            TargetPosition = transform.position
        };
        rotationComponent = new RotationComponent()
        {
            Direction = transform.forward,
            RotationSpeed = data.RotationSpeed,
            TargetRotation = transform.rotation
        };
    }

    void Update()
    {
        animator.SetFloat("Speed", movementComponent.Speed);
    }

    public void NotifyDirectionChanged()
    {
        Debug.Log("Input changed!");
        stateManager.SwitchState(stateManager.rotationState);
    }
    public void NotifyRotationFinished()
    {
        Debug.Log("Rotation finished!");
        stateManager.SwitchState(stateManager.moveState);
    }
    public void NotifyMovementFinished()
    {
        Debug.Log("Movement finished!");
        stateManager.SwitchState(stateManager.standState);
    }
}
