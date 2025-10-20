using UnityEngine;

public class BoardRotator : MonoBehaviour
{
    public float tiltAmount = 10f; // How far the board tilts
    public float tiltSpeed = 5f;   // How fast it tilts

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
            tiltX = -tiltAmount; // Tilt forward
        }
        if (Input.GetKey(KeyCode.S))
        {
            tiltX = tiltAmount;  // Tilt backward
        }
        if (Input.GetKey(KeyCode.A))
        {
            tiltZ = tiltAmount;  // Tilt left
        }
        if (Input.GetKey(KeyCode.D))
        {
            tiltZ = -tiltAmount; // Tilt right
        }

        // Combine inputs into one rotation
        Quaternion targetRotation = originalRotation * Quaternion.Euler(tiltX, 0f, tiltZ);

        // Smoothly rotate toward the target rotation
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * tiltSpeed);
    }
}
