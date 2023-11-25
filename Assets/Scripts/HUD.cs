using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        GameManager gameManager = GameManager.instance;

        if (gameManager != null)
        {
            gameManager.OnScoreChanged += UpdateScoreText;
        }
        
        UpdateScoreText(GameManager.instance.Score);
    }

    private void UpdateScoreText(int newScore)
    {
        scoreText.text = ": " + newScore;
    }
}
