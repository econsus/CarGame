using UnityEngine;

public class CameraFollow : MonoBehaviour
{   
    //I don't need to explain this
    [SerializeField] private Transform followObject;
    [SerializeField] private float cameraSmoothness = 5f;
    [SerializeField] private Vector3 followOffset = new Vector3(0f, 5f, -10f);

    private Vector3 targetPosition, smoothedPosition;

    private void LateUpdate()
    {
        
        if (followObject != null)
        {
            targetPosition = followObject.position + followOffset;
            //Using lerp to ease in and out camera follow
            //Count the current camera position to desired position, and smooth it's transition using lerp
            smoothedPosition = Vector3.Lerp(transform.position, targetPosition, cameraSmoothness * Time.deltaTime);
            transform.position = smoothedPosition;
        }
        else
        {
            Debug.LogWarning("Camera target is null.");
        }
    }
}
