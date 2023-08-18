using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPosZ = 28;
    private float DelayStart = 2;
    private float TimeInterval = 8f;


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
        int animalIndex = 0;
        Vector3 spawnPos = new Vector3(Random.Range(-25, -12), 2, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}