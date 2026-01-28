using UnityEngine;

public class SpeedTunnel : MonoBehaviour
{
    public float speedMultiplier = 1.5f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Rigidbody ballRb = other.GetComponent<Rigidbody>();

            // Get how the ball is currently moving
            Vector3 currentVelocity = ballRb.linearVelocity;

            // Increase speed, keep direction
            ballRb.linearVelocity = currentVelocity * speedMultiplier;
        }
    }
}
