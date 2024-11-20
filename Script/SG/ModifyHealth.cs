using UnityEngine;

public class ModifyHealth : MonoBehaviour
{
    public Health playerHealth; // Reference to the Health script
    public string damagingTag = "Enemy"; // Tag of objects that will damage the player

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has the specified tag
        if (collision.gameObject.CompareTag(damagingTag))
        {
            // Apply 1 damage
            playerHealth.TakeDamage(1);
            Debug.Log("Player took damage from: " + collision.gameObject.name);
        }
    }
}
