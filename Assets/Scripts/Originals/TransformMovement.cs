using UnityEngine;

public class TransformMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float rotationSpeed = 20f;

    private float vInput;
    private float hInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        //store inputs
        float vInput = Input.GetAxis("Vertical");
        float hInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * vInput * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * hInput * rotationSpeed * Time.deltaTime);
    }
}
