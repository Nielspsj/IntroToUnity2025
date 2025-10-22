using UnityEngine;

public class Ex_RigidbodyPlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    // Add a variable for the rigidBody

    // Runs once when we hit Play.
    void Start()
    {
        // Get the rigidBody of the object this script is on.
        // Store the Gotten rigidBody in the rigidBody variable you created above.
    }

    // Runs once per frame.
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Move forward in the player's facing direction
        Vector3 move = transform.forward * moveZ * moveSpeed;

        // What about the rotation?
    }

    // Run physics here if possible.
    private void FixedUpdate()
    {
        // Use linearVelocity
    }
}