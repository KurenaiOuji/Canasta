using UnityEngine;
using UnityEngine.SceneManagement;

public class _SceneManager : MonoBehaviour
{
    TimeManager timeManager;
    ScoreManager scoreManager;
    public int scene;

    void Start()
    {
        scoreManager = FindFirstObjectByType<ScoreManager>();
        timeManager = FindFirstObjectByType<TimeManager>();    
    }

    // Update is called once per frame
    void Update()
    {
        if((scoreManager._OldHighScore < scoreManager.m_Score) && (timeManager.ActualTime <= 0))
        {
            SceneManager.LoadScene(scene);
        }

        else if (timeManager.ActualTime <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
