using UnityEngine;

public class RotateTransform : MonoBehaviour
{
    public Vector3 rotationAxis = Vector3.up; // The axis to rotate around
    public float rotationRate = 90.0f; // Degrees per second

    private void Update()
    {
        // Calculate the rotation amount based on the rotation rate and time
        float rotationAmount = rotationRate * Time.deltaTime;

        // Apply the rotation to the transform
        transform.Rotate(rotationAxis, rotationAmount);
    }
}