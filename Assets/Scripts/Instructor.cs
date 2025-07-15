using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructor : MonoBehaviour
{
    public float startValue;
    public float endValue;

    public float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float output = Mathf.Lerp(startValue, endValue, currentTime);
        //if current time is equal to zero then lerp will give start value
        //if current time is equal to one then lerp will give end value
       
        Debug.Log(output.ToString());
    }
}