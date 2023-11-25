using UnityEngine;
using UnityEngine.SceneManagement;

public class _SceneManager : MonoBehaviour
{
    TimeManager timeManager;
    public int scene;

    void Start()
    {
        timeManager = FindFirstObjectByType<TimeManager>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(timeManager.ActualTime <= 0)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
