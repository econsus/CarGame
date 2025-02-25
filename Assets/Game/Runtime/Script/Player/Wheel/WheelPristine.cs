using UnityEngine;
using System.Collections.Generic;

public class WheelPristine : MonoBehaviour, IWheelState
{
    public float driveFactor = 1f;

    float IWheelState.driveFactor { 
        get => GetDriveFactor(); 
    }

    public float GetDriveFactor()
    {
        return driveFactor;
    }

    private void SetDriveFactor(float newDriveFactor)
    {
        driveFactor = newDriveFactor;
    }
}
