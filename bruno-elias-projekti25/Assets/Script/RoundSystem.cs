using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RoundSystem : MonoBehaviour
{
    public TMP_Text player1ScoreText;
    public TMP_Text player2ScoreText;

    public bool roundOver = false;

    public void Start() 
    {
        Globals.player1Score = 0;
        Globals.player2Score = 0;
    }

    public void RoundOver() 
    {
        if(Globals.player1Score > Globals.player2Score)
        {
            Globals.player1OverallScore ++;
        }
        else
        {
            Globals.player2OverallScore ++;
        }

        SceneManager.LoadScene("RandomMinigame");
        
    }

    public void p1AddScore() 
    {
        if(roundOver == true)
        {
            return;
        }
        else
        {
            Globals.player1Score ++;
            player1ScoreText.text = "" + Globals.player1Score;
        }
    }

    public void p2AddScore() 
    {
        if(roundOver == true)
        {
            return;
        }
        else
        {
            Globals.player2Score ++;
            player2ScoreText.text = "" + Globals.player2Score;
        }
    }

}