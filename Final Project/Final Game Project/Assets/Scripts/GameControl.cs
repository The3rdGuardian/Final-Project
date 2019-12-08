using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public AudioSource jumpSource;
    public AudioClip jumpClipone;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            jumpSource.clip = jumpClipone;
            jumpSource.Play();
        }

    }
}

