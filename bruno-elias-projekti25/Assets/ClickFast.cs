using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickFast : MonoBehaviour
{
    public RoundSystem roundSystem;

    public void Update()    
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            roundSystem.p1AddScore();
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            roundSystem.p2AddScore();
        }
    }
}
