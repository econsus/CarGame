using UnityEngine;

public class Wheel : MonoBehaviour
{
    private float driveFactor = 1;
    private WheelCollider wheelCollider;
    Vector3 wheelPosition;
    Quaternion wheelRotation;
    [SerializeField] Transform wheelModel;
    [SerializeField] public bool steerableWheel;
    [SerializeField] public bool motorizedWheel;
    [SerializeField] private WheelStates wheelState;
    public static Vector3 position;
    public static Quaternion rotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Start()
    {
        wheelCollider = GetComponent<WheelCollider>();
    }

    void Update()
    {
        //wheelCollider.GetWorldPose(out position, out rotation);
        //wheelModel.transform.position = wheelPosition;
        //wheelModel.transform.rotation = wheelRotation;
    }

    public float GetDriveFactor()
    {
        switch (wheelState)
        {
            case WheelStates.Pristine:
                return 1f;
            case WheelStates.Flat:
                return 0.5f;
            case WheelStates.Blown:
                return 0.2f;
            default:
                return 1f;
        }
    }

    public float GetSteerFactor()
    {
        switch (wheelState)
        {
            case WheelStates.Pristine:
                return 1f;
            case WheelStates.Flat:
                return 0.7f;
            case WheelStates.Blown:
                return 0.5f;
            default:
                return 1f;
        }
    }

    //public float GetDriveFactor()
    //{
    //    return driveFactor;
    //}

    //WheelState
    //Pristine = 1
    //Flat = 0.7
    //Blown = 0.5
    public void ChangeWheelState()
    {
        
    }
}
