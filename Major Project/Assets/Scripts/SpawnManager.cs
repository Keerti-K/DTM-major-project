using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 32;
    private float spawnPosZ = 28;
    private float DelayStart = 2;
    private float TimeInterval = 3f;


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
        Vector3 spawnPos = new Vector3(Random.Range(-8, spawnRangeX), 2, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
