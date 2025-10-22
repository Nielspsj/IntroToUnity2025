using UnityEngine;

public class SimplePlayerPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            // Example effect: increase health
            SimplePlayerHealth health = GetComponent<SimplePlayerHealth>();
            if (health != null)
            {
                health.currentHealth += 10;
            }

            // Remove the pickup from the scene
            Destroy(other.gameObject);
        }
    }
}