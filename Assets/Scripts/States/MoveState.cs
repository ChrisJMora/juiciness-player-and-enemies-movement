using UnityEngine;

public class MoveState : EntityBaseState
{

    public override void EnterState(EntityStateManager entity)
    {
        var mediator = entity.mediator;
        var inputComponent = mediator.inputComponent;
        var movementComponent = mediator.movementComponent;
        var currentPosition = entity.transform.position;
        var direction = inputComponent.Direction();

        movementComponent.TargetPosition = currentPosition + direction;
        Debug.Log("The entity will move in the direction of " + direction);
    }

    public override void UpdateState(EntityStateManager entity)
    {
        var mediator = entity.mediator;
        var inputComponent = mediator.inputComponent;
        var movementComponent = mediator.movementComponent;
        var currentPosition = entity.transform.position;
        var targetPosition = movementComponent.TargetPosition;
        var speed = movementComponent.Speed;
        var direction = inputComponent.Direction();

        entity.transform.position = Vector3.MoveTowards(currentPosition, targetPosition, speed * Time.deltaTime);

        if (currentPosition == targetPosition) 
            movementComponent.TargetPosition = currentPosition + direction;

        if (direction == Vector3.zero)
            mediator.NotifyMovementFinished();
    }
}
