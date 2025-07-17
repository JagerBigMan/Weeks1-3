using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ProcessingStation : MonoBehaviour
{
    public float activationDistance = 0.5f;
    public GameObject partToProcess;
    public GameObject circleOutput;
    public PartSpawner partsSpawner;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (partsSpawner.spawnedParts.Count > 0)
        {
            for (int index = 0; index < partsSpawner.spawnedParts.Count; index++)
            {
                float activationRange = Mathf.Abs(transform.position.x - partsSpawner.spawnedParts[index].transform.position.x);

                if (activationRange <= activationDistance)
                {
                    Destroy(partsSpawner.spawnedParts[index]);
                    

                    Vector3 spawnPosition = partsSpawner.spawnedParts[index].transform.position;

                    Instantiate(circleOutput, spawnPosition, Quaternion.identity);
                }
            }
        }
    }
}
    

