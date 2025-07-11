using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefabToSpawn;
    public Vector3 spawnPoint;
    List<GameObject> spawnedObjects = new List<GameObject>();
    public int frameRate;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = frameRate;
        //GameObject spawnedObject = Instantiate(prefabToSpawn);
        //spawnedObjects.Add(spawnedObject);

        //GameObject spawnedObject2 = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        //spawnedObjects.Add(spawnedObject2);

        //Destroy(spawnedObjects[0]);


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
           GameObject spawnedObject = Instantiate(prefabToSpawn);
           spawnedObjects.Add(spawnedObject);
        }

        if(Input.GetMouseButtonDown(1))
        {
            for (int i = 0; i < spawnedObjects.Count; i++)
            {
                Destroy(spawnedObjects[i]);
            }
            spawnedObjects.Clear();
        }

        
    }
}
