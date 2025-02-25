using UnityEngine;
using System.Collections.Generic;

public class DebugScript : MonoBehaviour
{
    [SerializeField] private List<Wheel> wheels;

    // Update is called once per frame
    void Update()
    {
        foreach (Wheel wheel in wheels)
        {
            //Debug.Log(wheel.GetWheelDriveFactor());
        }
    }
}
