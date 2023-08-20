using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawnManager : MonoBehaviour
{
    public GameObject[] gemPrefabs;
    private float DelayStart = 5;
    private float TimeInterval = 7f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnGemRandom", DelayStart, TimeInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnGemRandom()
    {
        int gemIndex = Random.Range(0, gemPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-23, 27), 1, Random.Range(10, 20));
        Instantiate(gemPrefabs[gemIndex], spawnPos, gemPrefabs[gemIndex].transform.rotation);
    }
}
