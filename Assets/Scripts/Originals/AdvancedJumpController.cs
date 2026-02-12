using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class AdvancedJumpController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float rotationSpeed = 180f;

    [Header("Jump Settings")]
    [SerializeField] private float jumpForce = 7f;
    [SerializeField] private int maxJumps = 2;

    [Header("Gravity")]
    [SerializeField] private float gravity = -20f;
    [SerializeField] private float fallMultiplier = 2.5f;
    [SerializeField] private float lowJumpMultiplier = 2f;

    [Header("Forgiveness Timers")]
    [SerializeField] private float coyoteTime = 0.15f;
    [SerializeField] private float jumpBufferTime = 0.15f;

    private CharacterController controller;

    private Vector3 moveDirection;
    private float verticalVelocity;

    private int jumpCount;
    private float coyoteCounter;
    private float jumpBufferCounter;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        HandleMovement();
        HandleTimers();
        HandleJump();
        ApplyGravity();

        controller.Move(moveDirection * Time.deltaTime);
    }

    // --------------------------
    // Movement (Tank Controls)
    // --------------------------
    void HandleMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Rotate left/right
        transform.Rotate(0f, horizontal * rotationSpeed * Time.deltaTime, 0f);

        // Forward/back movement
        Vector3 forwardMove = transform.forward * vertical * moveSpeed;
        moveDirection.x = forwardMove.x;
        moveDirection.z = forwardMove.z;
    }

    // --------------------------
    // Timers (Coyote + Buffer)
    // --------------------------
    void HandleTimers()
    {
        // Coyote Time
        if (controller.isGrounded)
        {
            coyoteCounter = coyoteTime;
            jumpCount = 0; // Reset jumps on landing

            if (verticalVelocity < 0f)
                verticalVelocity = -2f; // Stick to ground
        }
        else
        {
            coyoteCounter -= Time.deltaTime;
        }

        // Jump Buffer
        if (Input.GetButtonDown("Jump"))
        {
            jumpBufferCounter = jumpBufferTime;
        }
        else
        {
            jumpBufferCounter -= Time.deltaTime;
        }
    }

    // --------------------------
    // Jump Logic (Single + Double)
    // --------------------------
    void HandleJump()
    {
        bool canUseCoyoteJump = coyoteCounter > 0f && jumpCount == 0;
        bool canUseAirJump = jumpCount < maxJumps;

        if (jumpBufferCounter > 0f && (canUseCoyoteJump || canUseAirJump))
        {
            verticalVelocity = jumpForce;
            jumpCount++;
            jumpBufferCounter = 0f;
            coyoteCounter = 0f;
        }
    }

    // --------------------------
    // Gravity + Variable Jump Height
    // --------------------------
    void ApplyGravity()
    {
        // Better falling feel
        if (verticalVelocity < 0)
        {
            verticalVelocity += gravity * fallMultiplier * Time.deltaTime;
        }
        else if (verticalVelocity > 0 && !Input.GetButton("Jump"))
        {
            // Early release = shorter jump
            verticalVelocity += gravity * lowJumpMultiplier * Time.deltaTime;
        }
        else
        {
            verticalVelocity += gravity * Time.deltaTime;
        }

        moveDirection.y = verticalVelocity;
    }
}
