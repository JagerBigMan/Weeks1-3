using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public float conveyorBeltSpeed = 2f;
    public float activationDistance = 0.5f; //how close an object must be to get on the conveyor belt
    public Vector3 moveDirection = Vector3.down; //direction to push 

    public Sprite UnassembledParts; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
