using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public float speed = 5f;
    private int direction = 1;

    private float scaleMultiplier = 0.2f;
    private float speedMultiplier = 1f;
    private float minRandomSpeed = 1f;
    private float maxRandomSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * direction * Time.deltaTime;

        Vector3 BouncingBallPositionInScreenSpace = Camera.main.WorldToScreenPoint(transform.position);

        if (BouncingBallPositionInScreenSpace.x > Screen.width)
        {
            direction *= -1;
        }
        if (BouncingBallPositionInScreenSpace.x < 0)
        {
            direction *= -1;
        }

        //Increase the size using up arrow key
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.localScale += Vector3.one * scaleMultiplier;
        }
        //Decrease size using down arrow key
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.localScale -= Vector3.one * scaleMultiplier;
        }

        //Increase the speed using right arrow key
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            speed += speedMultiplier;
        }
         //Decrease the speed using left arrow key
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            speed -= speedMultiplier;
        }
        //Space to reset the position of the ball to 0,0 and make it run at a random speed
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = Vector3.zero; //reset it to 0 0 with no movement
            speed = Random.Range(minRandomSpeed, maxRandomSpeed); //this sets the ball at a random speed between 1 - 10
        }

        }
    }
