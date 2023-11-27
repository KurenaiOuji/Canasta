using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_ScoreText;
    [SerializeField] TextMeshProUGUI m_HighScoreText;
    public int m_Score;
    public int m_HighScore;
    public int m_OldHighScore;

    void Start()
    {
        //PlayerPrefs.SetInt("m_HighScore", 0);
        m_Score = 0000;
        m_HighScore = PlayerPrefs.GetInt("m_HighScore", 0);
        m_HighScoreText.text = "High Score: " + m_HighScore.ToString();
        m_OldHighScore = PlayerPrefs.GetInt("m_HighScore", 0);
    }

    void Update()
    {
        m_ScoreText.text = "Score: " + m_Score.ToString();

        if (m_Score > m_HighScore)
        {
            m_HighScore = m_Score;
            PlayerPrefs.SetInt("m_HighScore", m_Score);
            m_HighScoreText.text = "High Score: " + m_HighScore.ToString();
        }
    }
}
