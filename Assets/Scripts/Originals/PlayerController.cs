using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerController : MonoBehaviour
{
    //vTest 1: store inputs
    //vTest 2: store move direction
    //vTest 3: use ctrl.move to set the movement
    //vTest 4: if there is a direction then rotate the player to face the direction
    //vTest 5: smooth the rotation
    //vTest 6: Add fake gravity
    //vTest 7: Add jump force upwards in y axis on movedirection when we hit space


    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotationSpeed = 20f;
    [SerializeField] float gravity = -9.8f;
    [SerializeField] float jumpForce = 5f;

    private CharacterController playerCharCtrler;

    private Vector3 moveDirection;
    private float verticalVelocity;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerCharCtrler = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
        HandleJump();
        ApplyGravity();

        //use a centralized ctrl.move to set the movement
        playerCharCtrler.Move(moveDirection * Time.deltaTime);
    }

    private void UpdateMovement()
    {
        //store inputs
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
               

        //store move direction
        //Vector3 moveDirection = new Vector3(horizontal, 0f, vertical);
        //Strafe
        //Vector3 moveDirection = transform.right * horizontal + transform.forward * vertical;
        //No strafe
        moveDirection.x = transform.forward.x * vertical * moveSpeed;
        moveDirection.z = transform.forward.z * vertical * moveSpeed;

        transform.Rotate(0, horizontal * rotationSpeed * Time.deltaTime, 0);
    }

    private void HandleJump()
    {
        //Built in ground check. If we are not grounded then nothing in this method runs.
        if(!playerCharCtrler.isGrounded)
        {
            return;
        }

        //Push downwards to hold us on the ground
        if(verticalVelocity < 0f)
        {
            verticalVelocity = -2f;
        }

        //Temporarily add force upwards
        if (Input.GetKeyDown(KeyCode.Space))
        {
            verticalVelocity = jumpForce;
        }
    }

    //Add gravity all the time downwards
    private void ApplyGravity()
    {
        verticalVelocity += gravity * Time.deltaTime;
        moveDirection.y = verticalVelocity;
    }
}
