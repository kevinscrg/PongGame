using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    public float extraSpeed;
    public float maxSpeed;
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(this.InitBall());
    }
    public IEnumerator InitBall(bool player1_start = true)
    {
        this.StartPos(player1_start);
        this.count = 0;
        yield return new WaitForSeconds(2);
        if(player1_start)
        {   
            this.Movement(new Vector2(-1,0));
        }
        else
        {
            this.Movement(new Vector2(1, 0));
        }
    }

    public void Movement(Vector2 dir)
    {
        dir = dir.normalized;
        float speed = this.speed + this.count * this.extraSpeed;

        Rigidbody2D rigidbody = this.gameObject.GetComponent<Rigidbody2D>();
        if (rigidbody != null)
        {
            rigidbody.velocity = dir * speed;
        }
    }

    public void CountBounce()
    {
        if(this.count * this.extraSpeed <= this.maxSpeed)
        { 
            this.count++; 
        }
       
    }

    void StartPos(bool player1_start)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);

        if (player1_start)
        {
            this.gameObject.transform.localPosition = new Vector3(-100,0,0);
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(100, 0, 0);
        }


    }
}
