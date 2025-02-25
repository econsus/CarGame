using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform followObject;
    [SerializeField] private float cameraSmoothness = 5f;
    [SerializeField] private Vector3 followOffset = new Vector3(0f, 5f, -10f);

    private Vector3 targetPosition, smoothedPosition;

    private void LateUpdate()
    {
        
        if (followObject != null)
        {
            targetPosition = followObject.position + followOffset;

            smoothedPosition = Vector3.Lerp(transform.position, targetPosition, cameraSmoothness * Time.deltaTime);
            transform.position = smoothedPosition;
        }
        else
        {
            Debug.LogWarning("Camera target is null.");
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
