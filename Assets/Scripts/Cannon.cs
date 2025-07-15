using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject Cannonball;
    public float cannonballSpeed;
    public Color cannonballColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool leftClick = Input.GetMouseButtonDown(0);

        if (leftClick)
        {
           GameObject spawnedCannonball = Instantiate(Cannonball,transform.position,Quaternion.identity);
            Debug.Log(spawnedCannonball.name);
            SpriteRenderer cannonballRenderer = spawnedCannonball.GetComponent<SpriteRenderer>();

            //If we have successfully found a renderer, then we can do stuff with it

            if(cannonballRenderer !=null)
            {
                cannonballRenderer.color = cannonballColor;
            }
            else
            {
                //Don't do stuff with it!!
            }

            Cannonball cannonballScript = spawnedCannonball.GetComponent<Cannonball>();
            
            cannonballScript.moveDuration = cannonballSpeed;
        }
    }
}
