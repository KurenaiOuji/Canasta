using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] float TimeMax;
    [SerializeField] float ActualTime;

    void Start()
    {
        ActualTime = TimeMax;
        slider.maxValue = TimeMax;
    }

    void Update()
    {
        ActualTime -= Time.deltaTime;
        slider.value = ActualTime;
    }
}
