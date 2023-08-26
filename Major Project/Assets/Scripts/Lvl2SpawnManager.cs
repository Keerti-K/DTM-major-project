using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl2SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclesPrefabs;
    private float startDelay = 1f;
    private float repeatRate = 4f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacles", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacles()
    {
        int obstacleindex = Random.Range(0, obstaclesPrefabs.Length);
        Vector3 spawnPos = new Vector3(458, 120, -40);
        Instantiate(obstaclesPrefabs[obstacleindex], spawnPos, obstaclesPrefabs[obstacleindex].transform.rotation);
    }
}
