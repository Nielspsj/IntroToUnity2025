using UnityEngine;

public class RigidbodyPlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    [SerializeField] private float rotationSpeed = 100f;
    private float currentRotationSpeed;
    private Vector3 frozenRotation;
    private Rigidbody playerRigidBody;

    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        currentRotationSpeed = rotationSpeed;
        frozenRotation = transform.eulerAngles;
    }

    void FixedUpdate()
    {
        UpdateMovement();       
    }

    private void UpdateMovement()
    {     
        float turn = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");        

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            //Debug.Log("input: " + Input.GetAxis("Horizontal") + " - " + Input.GetAxis("Vertical"));
            // Move forward in the player's facing direction
            Vector3 move = transform.forward * moveZ * moveSpeed;
            playerRigidBody.linearVelocity = new Vector3(move.x, playerRigidBody.linearVelocity.y, move.z);

            // Rotate left/right
            transform.Rotate(Vector3.up * turn * currentRotationSpeed * Time.fixedDeltaTime);
        }
        else
        {
            //Debug.Log("NO input");
            playerRigidBody.linearVelocity = Vector3.zero;
            playerRigidBody.freezeRotation = true;
        }
        playerRigidBody.freezeRotation = false;
        playerRigidBody.constraints = RigidbodyConstraints.FreezeRotationZ;
        playerRigidBody.constraints = RigidbodyConstraints.FreezeRotationX;
        frozenRotation.y = transform.eulerAngles.y;
        transform.eulerAngles = frozenRotation;
    }
}