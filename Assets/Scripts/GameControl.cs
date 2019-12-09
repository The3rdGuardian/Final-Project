using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public Player playerScript;

    public AudioSource musicSource;
    public AudioClip musicClipone;

    void Start()
    {
        musicSource.clip = musicClipone;
        musicSource.Play();

    }

    void Update()
    {
        if(playerScript.scoreValue == 9)
        {
            musicSource.Stop();
            playerScript.GameWin();
        }
    }

}

