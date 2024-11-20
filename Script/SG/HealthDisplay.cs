using UnityEngine;
using UnityEngine.UI; // For UI components

public class HealthDisplay : MonoBehaviour
{
    public Health playerHealth; // Reference to the player's Health script
    public Text healthText; // UI Text component to display health

    void Update()
    {
        // Update the text to show the current health
        healthText.text = "Health: " + playerHealth.currentHealth;
    }
}
