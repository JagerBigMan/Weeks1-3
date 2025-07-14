using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMarch : MonoBehaviour
{
    public float stepDistance = 0.5f;
    public float stepInterval = 1f;

    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //adding the real world time to the timer
        if(timer > stepInterval) //this helps to continuously march down the alien march down the moment 0.5s real world time has passed
        {
            transform.position += Vector3.down * stepDistance; //this then moves the alien down by 1 unit
            timer = 0f;  //resetting the timer so that it can be run again
        }
    }
}
