using UnityEngine;

[System.Serializable]
public class InputComponent
{
    [SerializeField]
    private float _horizontal;
    [SerializeField]
    private float _vertical;
    
    public float Horizontal { set => _horizontal = value; }
    public float Vertical { set => _vertical = value; }
    public Vector3 Direction() => new (_horizontal, 0, _vertical);
}
