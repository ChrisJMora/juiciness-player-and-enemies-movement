using UnityEngine;

public class KeyInputBehaviour : MonoBehaviour, IInputType
{
    public Mediator mediator;

    void Update()
    {
        ReadInput();
    }

    public void ReadInput()
    {
        var priorDirection = CurrentDirection;

        InputComponent.Horizontal = Input.GetAxisRaw("Horizontal");
        InputComponent.Vertical = Input.GetAxisRaw("Vertical");

        if (CurrentDirection != Vector3.zero && priorDirection != CurrentDirection)
            mediator.NotifyDirectionChanged();
    }

    private InputComponent InputComponent => mediator.inputComponent;
    private Vector3 CurrentDirection => InputComponent.Direction();
}
