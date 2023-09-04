using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Score;
    private int ScoreNum;

    void Start()
    {
        ScoreNum = 0;
        Score.text = ": " + ScoreNum;
    }

    private void OnTriggerEnter2D(Collider2D Fruit)
    {

        if (Fruit.gameObject.CompareTag("Basket"))
        {
            ScoreNum++;
            Score.text = ": " + ScoreNum;
            Destroy(gameObject);
        }
    }

}
