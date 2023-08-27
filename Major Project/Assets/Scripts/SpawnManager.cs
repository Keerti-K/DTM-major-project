using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Array for spaceship prefabs
    public GameObject[] spaceshipPrefabs;
    // Fixed Variables
    private float spawnRangeX = 32;
    private float spawnPosZ = 28;
    private float DelayStart = 2;
    private float TimeInterval = 2f;


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
        //Spawns random enemy spaceships
        int spaceshipIndex = Random.Range(0, spaceshipPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-8, spawnRangeX), 2, spawnPosZ);
        Instantiate(spaceshipPrefabs[spaceshipIndex], spawnPos, spaceshipPrefabs[spaceshipIndex].transform.rotation);
    }
}
