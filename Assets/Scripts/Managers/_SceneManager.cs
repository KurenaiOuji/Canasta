using UnityEngine;
using UnityEngine.SceneManagement;

public class _SceneManager : MonoBehaviour
{
    TimeManager timeManager;
    ScoreManager scoreManager;
    PauseManager pauseManager;
    public int scene;

    void Start()
    {
        pauseManager = FindFirstObjectByType<PauseManager>();
        scoreManager = FindFirstObjectByType<ScoreManager>();
        timeManager = FindFirstObjectByType<TimeManager>();    
    }

    // Update is called once per frame
    void Update()
    {
        if((scoreManager._OldHighScore < scoreManager.m_Score) && (timeManager.ActualTime <= 0))
        {
            pauseManager.PauseUI = true;
        }

        else if (timeManager.ActualTime <= 0)
        {
            SceneManager.LoadScene(scene);
        }
    }

    public void ChangeScene(int ChangeScene)
    {
        SceneManager.LoadScene(ChangeScene);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
