using UnityEngine;

public class StickToPlatform : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // When touching a moving platform, parent the player to it
        if (collision.gameObject.CompareTag("MovingPlatform"))
        {
            transform.SetParent(collision.transform);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // When leaving the platform, unparent the player
        if (collision.gameObject.CompareTag("MovingPlatform"))
        {
            transform.SetParent(null);
        }
    }
}
