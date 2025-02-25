using TMPro;
using UnityEngine;

public class SpeedMeterUpdater : MonoBehaviour
{
    [SerializeField] CarPhysics carPhysics;
    [SerializeField] TextMeshProUGUI speedMeterText;

    // Update is called once per frame
    void Update()
    {
        speedMeterText.text = Mathf.RoundToInt(carPhysics.GetCurrentSpeed()).ToString() + "  Km/H";
    }
}
