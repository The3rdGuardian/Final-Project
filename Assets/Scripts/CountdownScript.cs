using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownScript : MonoBehaviour
{
    public bool isover = false;
    public float startingTime;

    public Text textTime;

    public Player playerScript;

    void Update()
    { 
        if(isover == false)
        {
            startingTime -= Time.deltaTime;
        }
        


        if(startingTime < 0)
        {
            startingTime = 0;
        }

        Countdown();
        textTime.text = "Time Remaining:" + Mathf.Round(startingTime);
 
    }

    void Countdown()
    {

        if (playerScript.scoreValue == 9)
        {
            isover = true;
            playerScript.GameWin();
        }
        if (startingTime == 0 && playerScript.scoreValue != 9)
        {
            playerScript.GameOver();
  
        }
    }
}


    

    