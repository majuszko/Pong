using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public KeyCode moveUp;
    public KeyCode moveDown;
    public float speed = 10f;
    public Rigidbody2D rb;
    
    void Update()
    {
        if (Input.GetKey(moveUp))
        {
            rb.velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(moveDown))
        {
            rb.velocity = new Vector2(0, -speed);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
