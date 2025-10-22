using UnityEngine;

public class RigidbodyPlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;
    private Rigidbody playerRigidBody;

    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float turn = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        
        // Move forward in the player's facing direction
        Vector3 move = transform.forward * moveZ * moveSpeed;
        playerRigidBody.linearVelocity = new Vector3(move.x, playerRigidBody.linearVelocity.y, move.z);

        // Rotate left/right
        transform.Rotate(Vector3.up * turn * rotationSpeed * Time.fixedDeltaTime);
    }
}