using UnityEngine;

public class AccelerationBehaviour : MonoBehaviour
{
    public Mediator mediator;
    public ParticleSystem dustParticles;

    private void Update() {

        if (mediator.inputComponent.Direction() != Vector3.zero)
        {
            if (Input.GetKey(KeyCode.RightShift))
            {
                Accelerate(mediator.data.SprintSpeed);
                dustParticles.Play();
            }
            else
                Accelerate(mediator.data.NormalSpeed);
        }
        else
            Decelerate();
    }

    public void Accelerate(float speedLimit)
    {
        var movementComponent = mediator.movementComponent;

        if (movementComponent.Speed < speedLimit) 
            movementComponent.Speed += 0.5f;
        else
            movementComponent.Speed = speedLimit;
    }

    public void Decelerate()
    {
        var movementComponent = mediator.movementComponent;

        if (movementComponent.Speed > 0) 
            movementComponent.Speed -= 0.5f;
        else
            movementComponent.Speed = 0;
    }
}
