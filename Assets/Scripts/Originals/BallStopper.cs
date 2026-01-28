using UnityEngine;

public class BallStopper : MonoBehaviour
{
    public float delayTime = 1.0f;

    private Vector3 storedVelocity;
    private Rigidbody ballRb;
    private float timer = 0f;
    private bool ballIsStopped = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ballRb = other.GetComponent<Rigidbody>();

            // Store how the ball was moving
            storedVelocity = ballRb.linearVelocity;

            // Stop the ball
            ballRb.linearVelocity = Vector3.zero;

            timer = delayTime;
            ballIsStopped = true;
        }
    }

    void FixedUpdate()
    {
        if (!ballIsStopped)
        {
            return;
        }

        timer -= Time.fixedDeltaTime;

        if (timer <= 0f)
        {
            // Restore movement
            ballRb.linearVelocity = storedVelocity;

            ballIsStopped = false;
        }
    }
}
