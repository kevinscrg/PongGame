using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    public BallMovement BallMove;
    public ScoreControll ScoreControll;
    void BounceOnRacket(Collision2D r)
    {
        Vector3 BallPos = this.transform.position;
        Vector3 RacketPos = r.gameObject.transform.position;
        float CollPos = r.collider.bounds.size.y;

        float x;
        float y;
        if(r.gameObject.name == "Racket1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }
        y = (BallPos.y - RacketPos.y)/CollPos;

        this.BallMove.CountBounce();
        this.BallMove.Movement(new Vector2(x,y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Racket1" || collision.gameObject.name == "Racket2")
        {
            this.BounceOnRacket(collision);
        }
        else if(collision.gameObject.name == "Left")
        {
            this.ScoreControll.Player2Scored();
            StartCoroutine(this.BallMove.InitBall(true));
        }
        else if (collision.gameObject.name == "Right")
        {
            this.ScoreControll.Player1Scored();
            StartCoroutine(this.BallMove.InitBall(false));
        }
    }
}
