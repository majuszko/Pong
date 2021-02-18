using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singleplayer : MonoBehaviour
{
    public float speed;
    public GameObject ball;
    public Rigidbody2D rb;

    private void FixedUpdate()
    {
        if (Mathf.Abs(transform.position.y - ball.transform.position.y) > 50)
        {
            if (transform.position.y < ball.transform.position.y)
            {
                rb.velocity = new Vector2(0,1)*speed;
            }
            else
            {
                rb.velocity = new Vector2(0,-1)*speed;
            }
        }
        else
        {
            rb.velocity = new Vector2(0,0);
        }
    }
}
