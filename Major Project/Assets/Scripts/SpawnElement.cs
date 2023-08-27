using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnElement : MonoBehaviour
{
    public GameObject[] gemPrefabs;
    public float DelayStart = 5f;
    private float TimeInterval = 100f;


    // Start is called before the first frame update
    void Start()
    {
        // Calls SpawnHiddenElement at the set time 
        InvokeRepeating("SpawnHiddenElement", DelayStart, TimeInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnHiddenElement()
    {
        // Spawns hidden element
        int gemIndex = Random.Range(0, gemPrefabs.Length);
        Vector3 spawnPos = new Vector3(458, 130, -40);
        Instantiate(gemPrefabs[gemIndex], spawnPos, gemPrefabs[gemIndex].transform.rotation);
    }
}


