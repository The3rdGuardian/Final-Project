using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject Player;
    public GameObject Portal;

    public AudioSource tpsound;
    public AudioClip musicClipone;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
          
            StartCoroutine(Teleporter());
        }
    }

    IEnumerator Teleporter()
    {
        yield return new WaitForSeconds(.5f);
        tpsound.clip = musicClipone;
        tpsound.Play();
        Player.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y);
    }
}
