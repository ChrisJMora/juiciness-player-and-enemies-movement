using System.Collections;
using UnityEngine;

public class RandomInputBehaviour : MonoBehaviour
{
    public Mediator mediator;

    void Start()
    {
        InvokeRepeating(nameof(ReadInput), 0f, 2f);
    }

    public void ReadInput()
    {
        var priorDirection = CurrentDirection;
        
        InputComponent.Horizontal = Random.Range(-1, 2);
        InputComponent.Vertical = Random.Range(-1, 2);

        if (CurrentDirection != Vector3.zero && priorDirection != CurrentDirection)
            mediator.NotifyDirectionChanged();
    }

    private InputComponent InputComponent => mediator.inputComponent;
    private Vector3 CurrentDirection => InputComponent.Direction();
}
