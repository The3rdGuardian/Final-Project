using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    Animator anim;

    public Transform startMarker;
    public Transform endMarker;

    public float speed = 1.0F;

    private float startTime;

    private float journeyLength;

    private bool facingRight = true;
    private bool currentlyfacingRight = false;

    Vector3 previousPosition;


    void Start()
    {
        anim = GetComponent<Animator>();

        startTime = Time.time;

        journeyLength = Vector2.Distance(startMarker.position, endMarker.position);
    }

    void Update()
    {
        

        float distCovered = (Time.time - startTime) * speed;

        float fracJourney = distCovered / journeyLength;

        transform.position = Vector2.Lerp(startMarker.position, endMarker.position, Mathf.PingPong(fracJourney, 1));

        Vector3 currentPosition = transform.position;
        bool facingRight = currentPosition.x - previousPosition.x > 0;
        previousPosition = currentPosition;

        if(facingRight == false)
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
            facingRight = false;
            anim.SetInteger("Condition", 1);

        }
       else if(facingRight == true)
        {
            anim.SetInteger("Condition", 1);
            transform.eulerAngles = new Vector3(0, 0, 0);
            facingRight = true;
        }
    }

}

