using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChoosePlay : MonoBehaviour
{
    public static string val;

    public void OnePLayer()
    {
        val = "";
        SceneManager.LoadScene("PlayScene");
    }

    public void TwoPlayers()
    {
        val = "Vertical2";
        SceneManager.LoadScene("PlayScene");
    }
}
