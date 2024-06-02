using UnityEngine;

[CreateAssetMenu(fileName = "EntityData", menuName = "Data/EntityData")]
public class EntityData : ScriptableObject
{
    [SerializeField]
    private float normalSpeed;
    [SerializeField]
    private float sprintSpeed;
    [SerializeField]
    private float rotationSpeed;


    public float NormalSpeed { get => normalSpeed; set => normalSpeed = value; }
    public float SprintSpeed { get => sprintSpeed; set => sprintSpeed = value; }
    public float RotationSpeed { get => rotationSpeed; set => rotationSpeed = value; }
}
