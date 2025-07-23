using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UI;
using TMPro; //https://learn.unity.com/tutorial/working-with-textmesh-pro, this link helped me on how to set up TMPro so that I can drag the TMPro component into the text slot.

public class Information : MonoBehaviour
{
    public GameObject earth;
    public GameObject mars;
    public GameObject venus;
    public TMP_Text infoText;
    public float hoverDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);  
        mousePosition.z = 0;

        //There is definitely something else that is more efficient but this works too
        if (Vector3.Distance(mousePosition, earth.transform.position) <= hoverDistance)     
        {
            infoText.text = "Earth";
        }
        else if (Vector3.Distance(mousePosition, mars.transform.position) <= hoverDistance)
        {
            infoText.text = "Mars";
        }
        else if (Vector3.Distance(mousePosition, venus.transform.position) <= hoverDistance)
        {
            infoText.text = "Venus";
        }
    }
}
