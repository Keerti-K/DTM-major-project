using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl2SpawnManager : MonoBehaviour
{
    // Array for obstacles
    public GameObject[] obstaclesPrefabs;
    private float startDelay = 1f;
    private float repeatRate = 4f;
    
    // Start is called before the first frame update
    void Start()
    {
        // Calls SpawnObstacles function at a certain time
        InvokeRepeating("SpawnObstacles", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacles()
    {
        // Spawns random obstacle every time
        int obstacleindex = Random.Range(0, obstaclesPrefabs.Length);
        Vector3 spawnPos = new Vector3(458, 120, -40);
        Instantiate(obstaclesPrefabs[obstacleindex], spawnPos, obstaclesPrefabs[obstacleindex].transform.rotation);
    }
}
