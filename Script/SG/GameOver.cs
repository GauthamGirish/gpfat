using UnityEngine;
using UnityEngine.SceneManagement; // For restarting the scene
using UnityEngine.UI; // For UI components

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen; // Reference to the Game Over UI Panel

    void Start()
    {
        // Ensure the game over screen is hidden at the start
        gameOverScreen.SetActive(false);
    }

    public void TriggerGameOver()
    {
        // Activate the Game Over screen
        gameOverScreen.SetActive(true);
        // Optionally, stop time to freeze the game
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        // Reset time scale
        Time.timeScale = 1f;
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
