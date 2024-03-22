using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreControll : MonoBehaviour
{
    private int P1Score =0;
    private int P2Score =0;

    public GameObject textScore1;
    public GameObject textScore2;

    public int WinScore;
    // Update is called once per frame
    void Update()
    {
      if(this.P1Score >= this.WinScore || this.P2Score >= this.WinScore)
        {
            SceneManager.LoadScene("FinishGame");
        }
    }

    private void FixedUpdate()
    {
        Text TagScore1 = this.textScore1.GetComponent<Text>();
        Text TagScore2 = this.textScore2.GetComponent<Text>();

        TagScore1.text = this.P1Score.ToString();
        TagScore2.text = this.P2Score.ToString();
    }

    public void Player1Scored()
    {
        this.P1Score++;
    }
    public void Player2Scored()
    {
        this.P2Score++;
    }

}
