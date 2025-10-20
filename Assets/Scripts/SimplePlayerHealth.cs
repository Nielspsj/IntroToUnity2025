using UnityEngine;

public class SimplePlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth = currentHealth - damageAmount;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // For now, just disable the player
        gameObject.SetActive(false);
        Debug.Log("Player died!");
    }
}