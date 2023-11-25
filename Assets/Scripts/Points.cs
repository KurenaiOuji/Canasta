using UnityEngine;

public class Points : MonoBehaviour
{
    public int valor = 1;
    public GameManager gameManager;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.IncreaseScore(1);
            Destroy(this.gameObject);
        }
    }
}
