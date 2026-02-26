using UnityEngine;

public class HazardsTrigger : MonoBehaviour
{
    [SerializeField] private int hazardDamage;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering is the ball
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().TakeDamage(hazardDamage);
        }
    }
}
