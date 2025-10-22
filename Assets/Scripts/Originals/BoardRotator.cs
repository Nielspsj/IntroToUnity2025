using UnityEngine;

public class BoardRotator : MonoBehaviour
{
    public float rotationAmount = 10f; // How far the board tilts
    public float rotationSpeed = 5f;   // How fast it tilts

    private Quaternion originalRotation;

    void Start()
    {
        // Save the starting rotation so we can return to it
        originalRotation = transform.rotation;
    }

    void Update()
    {
        float tiltX = 0f;
        float tiltZ = 0f;

        // Use WASD input
        if (Input.GetKey(KeyCode.W))
        {
            tiltX = -rotationAmount; // Tilt forward
        }
        if (Input.GetKey(KeyCode.S))
        {
            tiltX = rotationAmount;  // Tilt backward
        }
        if (Input.GetKey(KeyCode.A))
        {
            tiltZ = rotationAmount;  // Tilt left
        }
        if (Input.GetKey(KeyCode.D))
        {
            tiltZ = -rotationAmount; // Tilt right
        }

        // Combine inputs into one rotation
        Quaternion targetRotation = originalRotation * Quaternion.Euler(tiltX, 0f, tiltZ);

        // Smoothly rotate toward the target rotation
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
    }
}
