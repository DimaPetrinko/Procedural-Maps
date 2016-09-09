using UnityEngine;

public static class Noise
{
    public static float Value(Vector3 point, float frequency)
    {
        point *= frequency;
        int v = (int)point.x;
        return v % 2;
    }

}
