using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Image healthBar;
    // Player's starting health
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        // Initialize health at the start
        currentHealth = maxHealth;
        //Debug.Log("Player Health: " + currentHealth);
    }

    // Call this function to damage the player
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        healthBar.fillAmount = currentHealth / 100f;
        Debug.Log("Player took " + damageAmount + " damage. Current Health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Handle player death
    void Die()
    {
        Debug.Log("Player has died!");
        // For now, we'll just destroy the player object
        Destroy(gameObject);
    }
}
