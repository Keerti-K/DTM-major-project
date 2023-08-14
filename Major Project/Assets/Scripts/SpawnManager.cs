using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 25;
    private float spawnPosZ = 28;
    private float DelayStart = 2;
    private float TimeInterval = 2f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimalRandom", DelayStart, TimeInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAnimalRandom()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 2, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
