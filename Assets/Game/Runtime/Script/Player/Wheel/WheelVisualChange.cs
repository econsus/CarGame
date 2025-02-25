using UnityEngine;

public class WheelVisualChange : MonoBehaviour
{
    [SerializeField] private Material flatMaterial;
    [SerializeField] private Material BlownMaterial;

    public void ChangeMaterialToFlat(GameObject wheelObject)
    {
        wheelObject.GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void ChangeMaterialToBlown(GameObject wheelObject)
    {
        wheelObject.GetComponent<Renderer>().material.color = Color.red;
    }
}
