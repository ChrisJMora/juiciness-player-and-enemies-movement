using UnityEngine;

[System.Serializable]
public class MovementComponent
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _targetPosition;

    public MovementComponent() {}

    public float Speed { get => _speed; set => _speed = value; }
    public Vector3 TargetPosition { get => _targetPosition; set => _targetPosition = value; }
}
