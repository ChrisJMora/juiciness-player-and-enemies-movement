using UnityEngine;

[System.Serializable]
public class RotationComponent
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private Quaternion _targetRotation;

    public float RotationSpeed { get => _rotationSpeed; set => _rotationSpeed = value * 100f; }
    public Quaternion TargetRotation { get => _targetRotation; set => _targetRotation = value;}
    public Vector3 Direction
    {
        get => _direction;
        set
        {
            if(value != Vector3.zero)
            {
                _direction = value;
                _targetRotation = Quaternion.LookRotation(_direction);
            }
        }
    }
}
