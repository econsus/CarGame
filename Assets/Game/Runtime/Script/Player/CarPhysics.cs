using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class CarPhysics : MonoBehaviour
{
    private Rigidbody rigidBody;
    [SerializeField] Transform carCenterOfMass;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.centerOfMass = carCenterOfMass.position;
        //rigidBody.constraints = RigidbodyConstraints.FreezeRotationZ;
    }

    public Transform GetCarCenterOfMass()
    {
        return carCenterOfMass;
    }
}
