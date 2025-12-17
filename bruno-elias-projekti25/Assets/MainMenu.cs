using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("RandomMinigame");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
}
