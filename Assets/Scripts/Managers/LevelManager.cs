using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    

    public void ChangeScene(int SceneNum)
    {
        SceneManager.LoadScene(SceneNum);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
