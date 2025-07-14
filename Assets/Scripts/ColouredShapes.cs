using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColouredShapes : MonoBehaviour
{
    private SpriteRenderer colorChange;
    public GameObject randomColor;

    // Start is called before the first frame update
    void Start()
    {
        colorChange = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0; //making sure the main camera can see it

        if (Input.GetMouseButtonDown(0))
        {
            GameObject newShape = Instantiate(randomColor, mouseWorldPosition, Quaternion.identity);

            SpriteRenderer colorChange = newShape.GetComponent<SpriteRenderer>(); //Assigning random color
            if (colorChange != null)
            {
                colorChange.color = Random.ColorHSV();
            }

            float randomScale = Random.Range(0.5f, 2f);
            newShape.transform.localScale = new Vector3(randomScale, randomScale, 1f); 
        }


        float distance = Vector3.Distance(transform.position,mouseWorldPosition);

        if(distance < 1f)
        {
            colorChange.color = Color.red;
        }
        else
        {
            colorChange.color = Color.white;
        }
    }
}
