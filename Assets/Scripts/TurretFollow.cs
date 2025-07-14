using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFollow : MonoBehaviour
{
    public Camera gameCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = gameCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        Vector3 direction = mousePosition - transform.position;

        transform.right = direction;
    }
}
