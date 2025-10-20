using UnityEngine;

public class RigidbodyPlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ) * moveSpeed;

        rigidBody.linearVelocity = new Vector3(move.x, rigidBody.linearVelocity.y, move.z);
    }
}