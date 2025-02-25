using UnityEngine;

public class TireRipper : MonoBehaviour, IObstacle
{
    private WheelVisualChange wheelVisualChange;

    private void Start()
    {
        wheelVisualChange = new WheelVisualChange();
    }
    public void DamageWheel(GameObject wheelObject)
    {
        Debug.Log(wheelObject);
        //Modify Forward Friction
        WheelFrictionCurve frictionForward = wheelObject.GetComponent<WheelCollider>().forwardFriction;
        frictionForward.stiffness = 5f;
        frictionForward.asymptoteSlip = 15f;
        wheelObject.GetComponent<WheelCollider>().forwardFriction = frictionForward;

        //Modify Sideway Friction
        WheelFrictionCurve frictionSideway = wheelObject.GetComponent<WheelCollider>().sidewaysFriction;
        frictionSideway.stiffness = 5f;
        frictionSideway.asymptoteSlip = 17f;
        wheelObject.GetComponent<WheelCollider>().sidewaysFriction = frictionSideway;

        //Modify Wheel Size
        wheelObject.GetComponent<WheelCollider>().radius = 2.3f;

    }
    //Change wheel visual to red (For Blown Tire)
    public void ChangeWheelVisual(GameObject wheelObject)
    {
        wheelVisualChange.ChangeMaterialToBlown(wheelObject);
    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        GameObject contactObject = other.gameObject;
        if (contactObject.CompareTag("Wheel"))
        {
            DamageWheel(contactObject);
        }
        if (contactObject.CompareTag("WheelModel"))
        {
            ChangeWheelVisual(other.gameObject);
        }
    }
}
