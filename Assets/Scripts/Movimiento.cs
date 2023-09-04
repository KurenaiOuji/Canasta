using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public bool left = false;
    public bool right = false;

    public Rigidbody2D rb;
    public float speed;

    public void Leftbt()
    {
        left = true;
    }

    public void Leftno() 
    {
        left = false;
    }

    public void Rightbt()
    {
        right = true;
    }

    public void Rightno()
    {
        right = false;
    }

    private void Update()
    {
        if (left)
        {
            rb.AddForce(new Vector2(-speed,0));
        }

        if( right)
        {
            rb.AddForce(new Vector2(speed,0));
        }
    }
}
