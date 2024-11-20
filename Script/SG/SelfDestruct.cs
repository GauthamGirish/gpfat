using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public string[] destroyOnTags = { "Ground", "Player" }; // Tags that will trigger destruction

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has one of the specified tags
        foreach (string tag in destroyOnTags)
        {
            if (collision.gameObject.tag == tag)
            {
                Destroy(gameObject); // Destroy this GameObject (enemy)
                Debug.Log("Enemy destroyed on collision with: " + collision.gameObject.name);
                return; // Exit after destruction to avoid unnecessary checks
            }
        }
    }
}
