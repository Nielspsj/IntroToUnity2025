using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerController : MonoBehaviour
{
    //Test 1: store inputs
    //Test 2: store move direction
    //Test 3: use ctrl.move to set the movement
    //Test 4: if there is a direction then rotate the player to face the direction
    //Test 5: smooth the rotation


    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotationSpeed = 20f;

    private CharacterController playerCharCtrler;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerCharCtrler = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
        //UpdateMoveModern();
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
        Vector3 moveDirection = transform.forward * vertical;

        //use ctrl.move to set the movement
        playerCharCtrler.Move(moveDirection * moveSpeed * Time.deltaTime);

        float turn = horizontal * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, turn, 0);
    }

    private void UpdateMoveModern()
    {
        //store inputs
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 inputDir = new Vector3(horizontal, 0f, vertical);

        if (inputDir.magnitude > 0.1f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(inputDir);
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                targetRotation,
                rotationSpeed * Time.deltaTime
            );
        }

        playerCharCtrler.Move(inputDir * moveSpeed * Time.deltaTime);
    }
}
