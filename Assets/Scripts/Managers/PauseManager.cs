using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public bool PauseUI;
    [SerializeField] GameObject PauseMenu;
    void Start()
    {
        PauseUI = false;
    }

    void Update()
    {
        if (PauseUI)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
