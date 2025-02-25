using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float turnSpeed = 5f;
    private Rigidbody rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // Get input for moving forward/backward
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            Drive();
        }
    }

    private void ApplySteering(float turnInput)
    {
        // Calculate the amount of torque to apply based on input and turn speed
        float torque = turnInput * turnSpeed;
        Debug.Log("Torque: " + torque);
        rigidBody.AddTorque(0, torque, 0);
    }

    private void Drive()
    {
        float moveInput = Input.GetAxis("Vertical");
        Vector3 moveForce = transform.forward * moveInput * moveSpeed;
        Debug.Log("Move Force: " + moveForce);

        // Get input for turning
        float turnInput = Input.GetAxis("Horizontal");
        ApplySteering(turnInput);

        // Apply force for movement
        rigidBody.AddForce(moveForce);
    }
}
