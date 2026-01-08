using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    public float rotationSpeed;
    public float clampAngle;

    private float currentRotationX = 0;
    private float tiltX = 0;

    void Update()
    {
        //float tiltX = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.W))
        {
            tiltX = 1;
            currentRotationX += tiltX * rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            tiltX = -1;
            currentRotationX += tiltX * rotationSpeed * Time.deltaTime;
        }

        

        currentRotationX = Mathf.Clamp(currentRotationX, -clampAngle, clampAngle);

        transform.rotation = Quaternion.Euler(currentRotationX, 0, 0);
    }
}
