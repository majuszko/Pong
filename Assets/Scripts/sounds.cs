using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounds : MonoBehaviour
{
    public AudioSource paddle;
    public AudioSource wall;
    public AudioSource Trigwall;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            paddle.Play();
        }
        else if (other.collider.CompareTag("trigWall"))
        {
            Trigwall.Play();
        }
        else
        {
            wall.Play();
        }
        
    }

    
}
