using UnityEngine;

public class StandState : EntityBaseState
{
    public override void EnterState(EntityStateManager entity)
    {
        Debug.Log("The entity is standing still.");
    }

    public override void UpdateState(EntityStateManager entity)
    {
        // Debug.Log("Waiting for input to move.");
    }
}
