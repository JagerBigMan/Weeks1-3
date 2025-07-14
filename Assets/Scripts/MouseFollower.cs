using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollower : MonoBehaviour
{
    public Vector3 screenPosition;
    public Vector3 worldPosition;
    public Camera gameCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        screenPosition = Input.mousePosition;
        screenPosition.z = 1;

        worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        transform.position = worldPosition;
    }
    //used this video to help me understand how to convert mouset position to world space in Unity.
    //Some codes aren't as quite the same from the ones taught in class but it works for me.
    //https://www.youtube.com/watch?v=5NTmxDSKj-Q

}
