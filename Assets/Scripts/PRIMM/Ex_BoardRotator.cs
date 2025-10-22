using UnityEngine;

public class Ex_BoardRotator : MonoBehaviour
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
        // Variables for the current rotation
        float rotationX = 0f;

        // Use WASD input
        if (Input.GetKey(KeyCode.W))
        {
            rotationX = -rotationAmount; // Rotate forward
        }
        if (Input.GetKey(KeyCode.S))
        {
            rotationX = rotationAmount;  // Rotate backward
        }
        // Add inputs for rotation on z-axis here. F.x. A and D.


        // Combine inputs into one rotation
        Quaternion targetRotation = originalRotation * Quaternion.Euler(rotationX, 0f, 0f);

        // Smoothly rotate toward the target rotation
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
    }
}
