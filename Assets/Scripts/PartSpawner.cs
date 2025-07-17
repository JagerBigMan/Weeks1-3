using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartSpawner : MonoBehaviour
{
    public GameObject unassembledPartPrefab;
    public List<GameObject> spawnedParts;

    // Start is called before the first frame update
    void Start()
    {
        spawnedParts = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPosition.z = 0;

            GameObject spawnedUnassembledParts = Instantiate(unassembledPartPrefab, mouseWorldPosition, Quaternion.identity);
            spawnedParts.Add(spawnedUnassembledParts);
        }
    }
}
