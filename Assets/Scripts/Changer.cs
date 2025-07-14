using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Changer : MonoBehaviour
{
    private float timeAlive =0f;

    private int direction = 1;

    public SpriteRenderer colorChange;

    //After 3 seconds have passed � change the colour of the object to green.

    //After 4 seconds have passed � change the size of the object to be twice as large.

    //After 5 seconds have passed � rotate the object by 180 degrees.

    //After 6 seconds have passed � destroy the object.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeAlive += Time.deltaTime;

        if(timeAlive > 3)
        {
            colorChange.color = Color.green;
        }
        
    }
}
