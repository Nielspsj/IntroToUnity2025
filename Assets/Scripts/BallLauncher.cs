using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    public float launchForce = 500f; // How strong to launch the ball
    private Rigidbody ballRb;

    void Start()
    {
        // Find the ball in the scene (make sure it’s tagged "Ball")
        ballRb = GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody>();
    }

    void Update()
    {
        // When you press space, launch the ball
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LaunchBall();
        }
    }

    void LaunchBall()
    {
        if (ballRb != null)
        {
            // Add a push forward (along Z axis)
            ballRb.AddForce(Vector3.forward * launchForce);
        }
    }
}
