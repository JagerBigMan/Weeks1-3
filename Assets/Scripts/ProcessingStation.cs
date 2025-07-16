using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessingStation : MonoBehaviour
{
    public float activationDistance = 0.5f;
    public GameObject partToProcess;
    public GameObject circleOutput;  


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (partToProcess != null)
        {
            float distance = Vector3.Distance(transform.position, partToProcess.transform.position);

            if (distance <= activationDistance)
            {
                Vector3 spawnPosition = partToProcess.transform.position;
                Destroy(partToProcess);
                Instantiate(circleOutput, spawnPosition, Quaternion.identity);
            }
        }
    }
}
