using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControll : MonoBehaviour
{
    public AudioSource audioRacket;
    public AudioSource audioWall;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Racket1" || collision.gameObject.name == "Racket2")
        {
            this.audioRacket.Play();
        }
        else
        {
            this.audioWall.Play();
        }
    }
}
