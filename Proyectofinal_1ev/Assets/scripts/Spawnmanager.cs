using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    private float randomX;
    private float randomY;
    private float randomZ;

    private float xRange = 100f;
    private float yRange = 100f;
    private float zRange = 100f;
    private float lowRange = 50f;

    public GameObject obstaclePrefab;
    private Vector3 spawnPosition;

    private float startTime = 2f;
    private float repeatRate = 5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startTime, repeatRate);
    }
    public Vector3 RandomSpawnPosition()
    {
        randomX = Random.Range(-xRange, xRange);
        randomY = Random.Range(lowRange, yRange);
        randomZ = Random.Range(-zRange, zRange);
        return new Vector3(randomX, randomY, randomZ);
    }

    public void SpawnObstacle()
    {
        
        spawnPosition = RandomSpawnPosition();
        Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
    }
}
