using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownScript : MonoBehaviour
{

    public float startingTime;

    private readonly Text textTime;

    public Player playerScript;


    void Update()
    {
        Debug.Log(startingTime -= Time.deltaTime);
        startingTime -= Time.deltaTime;

        if(startingTime < 0)
        {
            startingTime = 0;
        }

        Countdown();
        textTime.text = "Time Remaining:" + Mathf.Round(startingTime);
 
    }

    void Countdown()
    {
        if (startingTime == 0)
        {
            playerScript.GameOver();
        }
    }
}


    

    