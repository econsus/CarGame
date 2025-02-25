using UnityEngine;
using System.Collections.Generic;

public class CarController2 : MonoBehaviour
{
    [SerializeField] private float motorTorque;
    [SerializeField] private float brakeTorque;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float steeringAngle;
    [SerializeField] private float steeringAngleAtMaxSpeed;
    private Rigidbody rigidBody;
    [SerializeField] List<GameObject> wheels;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        VehicleControl();
    }


    private void VehicleControl()
    {
        float vInput = Input.GetAxis("Vertical");
        float hInput = Input.GetAxis("Horizontal");
        float forwardSpeed = Vector3.Dot(transform.forward, rigidBody.linearVelocity);
        float speedFactor = Mathf.InverseLerp(0, maxSpeed, forwardSpeed);
        float currentMotorTorque = Mathf.Lerp(motorTorque, 0, speedFactor);
        float currentSteerRange = Mathf.Lerp(steeringAngle, steeringAngleAtMaxSpeed, speedFactor);
        bool isAccelerating = Mathf.Sign(vInput) == Mathf.Sign(forwardSpeed);
        foreach (GameObject wheelObject in wheels)
        {
            WheelCollider wheelCollider = wheelObject.GetComponent<WheelCollider>();
            Wheel wheel = wheelObject.GetComponent<Wheel>(); 
            if (isAccelerating)
            {
                if (wheel.motorizedWheel)
                {
                    wheelCollider.motorTorque = vInput * currentMotorTorque * wheel.GetDriveFactor(); ;
                }
            }
            if (wheel.steerableWheel)
            {
                wheelCollider.steerAngle = hInput * currentSteerRange * wheel.GetSteerFactor();
            }
            if (Input.GetKey(KeyCode.Space))
            {
                wheelCollider.brakeTorque = brakeTorque;
            }
            else
            {
                wheelCollider.brakeTorque = 0;
            }
        }
    }
}
