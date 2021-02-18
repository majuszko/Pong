using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour {

    public float movementSpeed;
    public float extraSpeedPerHit;
    public float maxExtraSpeed;

    int hitCounter = 0;


    // Use this for initialization
    void Start () {
        StartCoroutine(this.StartBall());
    }


    void PositionBall(bool isStartingPlayer1){
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);

        if(isStartingPlayer1){
            this.gameObject.transform.localPosition = new Vector3(-100, 0, 0);
        }else{
            this.gameObject.transform.localPosition = new Vector3(100, 0, 0);
        }

    }


    public IEnumerator StartBall(bool isStartingPlayer1 = true){

        this.PositionBall(isStartingPlayer1);

        this.hitCounter = 0;
        yield return new WaitForSeconds(2);
        if (isStartingPlayer1)
            this.MoveBall(new Vector2(-1, 0));
        else  {
            this.MoveBall(new Vector2(1, 0));
        }

    }

    public void MoveBall(Vector2 dir){

        dir = dir.normalized;

        float speed = this.movementSpeed + this.hitCounter * this.extraSpeedPerHit;

        Rigidbody2D rigidBody2D = this.gameObject.GetComponent<Rigidbody2D>();

        rigidBody2D.velocity = dir * speed;
    }


    public void IncreaseHitCounter(){
        if(this.hitCounter * this.extraSpeedPerHit <= this.maxExtraSpeed){
            this.hitCounter++;
        }
    }

}


/*
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 2000f;
    public float speedInc = 2000f;
    private int hits = 1;
    
    void Start()
    {
        
        float rand = Random.Range(0, 2);

        if (rand <= 0.5)
        {
            rb.AddForce(new Vector2(speed*Time.deltaTime, speed/2*Time.deltaTime));
           
        }
        else
        {
            rb.AddForce(new Vector2(-speed*Time.deltaTime, -speed/2*Time.deltaTime));
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        
        if (coll.collider.CompareTag("Player"))
        {
            
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y/2 + coll.collider.GetComponent<Rigidbody2D>().velocity.y / 3, 0f);
            speed = speedInc + speed;
            hits++;
            
        
        }
    }

    void BallPosition(bool isStartingP1)
    {
        this.GetComponent<Rigidbody2D>().velocity= new Vector2(0,0);
        if (isStartingP1)
        {
            this.gameObject.transform.localPosition = new Vector3(-100,0,0);
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(100,0,0);
        }
    }
}
*/

