using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltController : MonoBehaviour
{
    //Rotation variables for the Inspector
    public float rotationSpeed;
    public float maxRotation;

    //Variables to store the rotation as we push and hold down inputs
    private float currentRotationX = 0;
    private float currentRotationZ = 0;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            currentRotationX += rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            currentRotationX -= rotationSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            currentRotationZ += rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            currentRotationZ -= rotationSpeed * Time.deltaTime;
        }

        //Keep the rotation within a max amount.
        currentRotationX = Mathf.Clamp(currentRotationX, -maxRotation, maxRotation);
        currentRotationZ = Mathf.Clamp(currentRotationZ, -maxRotation, maxRotation);

        //Store the rotation into the transform component of our gameobject.
        transform.rotation = Quaternion.Euler(currentRotationX, 0, currentRotationZ);
    }
}
