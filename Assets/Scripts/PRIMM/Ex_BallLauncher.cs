using UnityEngine;

public class Ex_BallLauncher : MonoBehaviour
{
    public float launchForce = 500f; // How strong to launch the ball
    private Rigidbody ballRigidbody;

    void Start()
    {
        // Find the ball in the scene (make sure it’s tagged "Ball")
        ballRigidbody = GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody>();
    }

    void Update()
    {
        // When you press space, launch the ball
        
    }

    void LaunchBall()
    {
        
    }
}
