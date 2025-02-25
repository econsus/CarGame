using UnityEngine;

public class WheelFlat : IWheelState
{
    public float driveFactor = 0.6f;

    float IWheelState.driveFactor
    {
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
