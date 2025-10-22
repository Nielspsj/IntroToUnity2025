using UnityEngine;

public class SimplePlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;

    void Update()
    {
        float turn = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * moveZ * moveSpeed * Time.deltaTime);

        transform.Rotate(Vector3.up * turn * rotationSpeed * Time.deltaTime);
    }
}