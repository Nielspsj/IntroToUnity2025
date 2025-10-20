using UnityEngine;

public class BallChargingLauncher : MonoBehaviour
{
    public float maxPower = 1000f;   // The strongest launch force
    public float chargeSpeed = 500f; // How fast you build up power
    public KeyCode launchKey = KeyCode.Space; // The key to launch with

    private float currentPower = 0f;
    private bool isCharging = false;
    private Rigidbody ballRb;

    void Start()
    {
        // Find the ball (make sure it's tagged "Ball")
        ballRb = GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Start charging when you hold the key
        if (Input.GetKey(launchKey))
        {
            isCharging = true;
            currentPower += chargeSpeed * Time.deltaTime;
            currentPower = Mathf.Clamp(currentPower, 0f, maxPower);
        }

        // Launch when you release the key
        if (Input.GetKeyUp(launchKey) && isCharging)
        {
            LaunchBall();
            currentPower = 0f;
            isCharging = false;
        }
    }

    void LaunchBall()
    {
        if (ballRb != null)
        {
            ballRb.AddForce(Vector3.forward * currentPower); // Launch along the Z-axis
        }
    }
}
