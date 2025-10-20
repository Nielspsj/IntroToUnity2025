using UnityEngine;

public class SimpleEnemyBullet : MonoBehaviour
{
    public int damage = 10;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SimplePlayerHealth playerHealth = collision.gameObject.GetComponent<SimplePlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }

            Destroy(gameObject); // Destroy the bullet after hitting
        }
    }
}