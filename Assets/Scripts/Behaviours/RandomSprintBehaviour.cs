using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprintBehaviour : MonoBehaviour
{
    public Mediator mediator;
    public ParticleSystem dustParticles;

    private void Update() {

        if (mediator.inputComponent.Direction() != Vector3.zero)
        {
            if (CheckProbability(0.1f))
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

    public bool CheckProbability(float probability)
    {
        // Generate a random number between 0 and 1
        float randomValue = Random.value;
        // Check if the random number is less than the probability
        return randomValue < probability;
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
