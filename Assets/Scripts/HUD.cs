using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        // Find the GameManager instance
        GameManager gameManager = GameManager.instance;

        // Check if the GameManager instance exists
        if (gameManager != null)
        {
            // Subscribe to the score change event
            gameManager.OnScoreChanged += UpdateScoreText;
        }
        else
        {
            Debug.LogWarning("GameManager instance not found.");
        }

        // Update the initial score text
        UpdateScoreText(GameManager.instance.Score);
    }

    private void UpdateScoreText(int newScore)
    {
        // Update the Text component with the new score
        scoreText.text = ": " + newScore;
    }
}
