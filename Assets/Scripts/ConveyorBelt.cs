using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public float conveyorBeltSpeed = 2f;
    public GameObject partToMove; //This is where I will put the prefab so that it will detect it and move it
    public float activationDistance = 5f; //how close an object must be to get on the conveyor belt
    public Vector3 moveDirection = Vector3.right; //direction to push 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (partToMove != null)
        {
            float distance = Vector3.Distance(transform.position, partToMove.transform.position);

            if (distance <= activationDistance)
            {
                partToMove.transform.position += moveDirection * conveyorBeltSpeed * Time.deltaTime;
            }
        }
    }
}
