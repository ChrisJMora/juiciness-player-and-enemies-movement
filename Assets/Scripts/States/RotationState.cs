using UnityEngine;

public class RotationState: EntityBaseState
{
    public override void EnterState(EntityStateManager entity)
    {
        var mediator = entity.mediator;
        var inputComponent = mediator.inputComponent;
        var rotationComponent = mediator.rotationComponent;

        rotationComponent.Direction = inputComponent.Direction();
        Debug.Log("The entity will rotate in the direction of " + rotationComponent.Direction);
    }

    public override void UpdateState(EntityStateManager entity)
    {
        var mediator = entity.mediator;
        var rotationComponent = mediator.rotationComponent;
        var currentRotation = entity.transform.rotation;
        var targetRotation = rotationComponent.TargetRotation;
        var speed = rotationComponent.RotationSpeed;

        if (currentRotation == targetRotation) mediator.NotifyRotationFinished();
        var angle = speed * Time.deltaTime;
        entity.transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, angle);
    }
}
