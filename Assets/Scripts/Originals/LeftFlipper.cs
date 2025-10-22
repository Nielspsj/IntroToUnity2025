using UnityEngine;

public class LeftFlipper : MonoBehaviour
{
    public KeyCode flipperKey = KeyCode.LeftArrow; // The key to control the flipper
    public float restAngle = 0f;     // The flipper's normal rotation
    public float activeAngle = 45f;  // The flipper's raised rotation
    public float flipSpeed = 10f;    // How fast the flipper moves

    private float currentAngle;

    void Start()
    {
        currentAngle = restAngle;
    }

    void Update()
    {
        // If the player presses the flipper key, move to the active angle
        if (Input.GetKey(flipperKey))
        {
            currentAngle = Mathf.Lerp(currentAngle, activeAngle, Time.deltaTime * flipSpeed);
        }
        else
        {
            // Otherwise, return to rest
            currentAngle = Mathf.Lerp(currentAngle, restAngle, Time.deltaTime * flipSpeed);
        }

        // Apply the rotation to the flipper
        transform.localRotation = Quaternion.Euler(0f, currentAngle, 0f);
    }
}
