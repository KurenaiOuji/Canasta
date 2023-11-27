using TMPro;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public bool PauseUI;

    [SerializeField] GameObject PauseMenu;
    [SerializeField] TextMeshProUGUI m_ScoreText;
    [SerializeField] TextMeshProUGUI m_OldHighScoreText;

    ScoreManager m_ScoreManager;

    void Start()
    {
        m_ScoreManager = FindFirstObjectByType<ScoreManager>();
        PauseUI = false;
    }

    void Update()
    {
        if (PauseUI)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }

        else
        {
            PauseMenu?.SetActive(false);
            Time.timeScale = 1f;
        }

        m_ScoreText.text = m_ScoreManager.m_Score.ToString();
        m_OldHighScoreText.text = m_ScoreManager.m_OldHighScore.ToString();
    }
}
