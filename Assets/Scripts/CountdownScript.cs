using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownScript : MonoBehaviour
{

    public float startingTime;

    public Text textTime;

    public Player playerScript;
    float hold;

    void Update()
    { 
        startingTime -= Time.deltaTime;
        hold = startingTime;

        if(startingTime < 0)
        {
            startingTime = 0;
        }

        Countdown();
        textTime.text = "Time Remaining:" + Mathf.Round(startingTime);
 
    }

    void Countdown()
    {
        if (startingTime != 0 && playerScript.scoreValue == 11)
        {
            startingTime = hold;
            playerScript.GameWin();
        }
        else if (startingTime == 0)
        {
            playerScript.GameOver();
  
        }
    }
}


    

    