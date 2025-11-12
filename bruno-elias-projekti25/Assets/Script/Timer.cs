using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.SceneManagement;
 
public class TimerScript : MonoBehaviour
{
    public TMP_Text txtTime;
    public float currentTime = 0f;
    public float startingTime = 60f;
    public bool timerActive = true;
    public RoundSystem roundSystem;

    void Start()
    {
        currentTime = startingTime;
    }
 
    void Update()
    {
        if(timerActive == true)
        {
            currentTime -= 1 * Time.deltaTime;
            txtTime.text = "" + Math.Round(currentTime);
            if (currentTime <= 0)
            {
                roundSystem.RoundOver();
                timerActive = false;
                roundSystem.roundOver = true;
            }
        } 
    }
}
