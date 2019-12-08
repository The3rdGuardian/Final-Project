using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinNoise : MonoBehaviour
{
    public GameObject jem;

    public AudioSource coinSource;
    public AudioClip coinClipone;

    void Start()
    {
        jem = GetComponent<GameObject>();
    }
    private void OnDestroy()
    {
        coinSource.clip = coinClipone;
        coinSource.Play();
    }
}
