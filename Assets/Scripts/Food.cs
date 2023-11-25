using UnityEngine;

public class Food : MonoBehaviour
{
    public int points;

    ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindFirstObjectByType<ScoreManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            scoreManager.m_Score += points;
        }
    }
}
