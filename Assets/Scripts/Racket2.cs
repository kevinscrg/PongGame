using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket2AI : MonoBehaviour
{
    public float speed;
    public GameObject Ball;
    private string val = ChoosePlay.val;

    private void FixedUpdate()
    {
        if (val == "Vertical2")
        {
            float v = Input.GetAxisRaw(val);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, v * speed);
        }
        else
        {
            if (Mathf.Abs(this.transform.position.y - Ball.transform.position.y) > 50)
            {
                if (transform.position.y < Ball.transform.position.y)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * speed;
                }
                else
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * speed;
                }
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }
        }

    }

}
