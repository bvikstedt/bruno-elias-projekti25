using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public RoundSystem roundSystem;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "p1")
        {
            roundSystem.p1AddScore();
            roundSystem.RoundOver();
        }
        if (other.gameObject.tag == "p2")
        {
            roundSystem.p2AddScore();
            roundSystem.RoundOver();
        }
    }
}
