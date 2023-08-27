using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
    public GameObject[] spaceshipPrefabs;
    // Fixed variables
    private float spawnPosZ = 28;
    private float DelayStart = 4;
    private float TimeInterval = 8f;


    // Start is called before the first frame update
    void Start()
    {
        // Calls SpawnspaceshipRandom at a certain time with a time gap
        InvokeRepeating("SpawnspaceshipRandom", DelayStart, TimeInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnspaceshipRandom()
    {
        //Spawns enemy spaceship at a random position
        int spaceshipIndex = 0;
        Vector3 spawnPos = new Vector3(Random.Range(-25, -12), 2, spawnPosZ);
        Instantiate(spaceshipPrefabs[spaceshipIndex], spawnPos, spaceshipPrefabs[spaceshipIndex].transform.rotation);
    }
}