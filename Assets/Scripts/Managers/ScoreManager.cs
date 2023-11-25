using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_TextMeshProUGUI;
    public int m_Score;

    void Start()
    {
        m_Score = 0000;
    }

    void Update()
    {
        m_TextMeshProUGUI.text = "Score: " + m_Score.ToString();
    }
}
