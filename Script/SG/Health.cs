using UnityEngine;

public class Health : MonoBehaviour
{
    public int MaxHealth = 100; // Set this value in the inspector or code
    public int currentHealth;

    void Start()
    {
        // Initialize health to the maximum at the start
        currentHealth = MaxHealth;
        Debug.Log("Health Initialized: " + currentHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Max(currentHealth, 0); // Prevent health from going below zero
        Debug.Log("Damage Taken: " + damage + ", Current Health: " + currentHealth);
    }

    public void Heal(int healAmount)
    {
        currentHealth += healAmount;
        currentHealth = Mathf.Min(currentHealth, MaxHealth); // Prevent health from exceeding max
        Debug.Log("Healed: " + healAmount + ", Current Health: " + currentHealth);
    }
}
