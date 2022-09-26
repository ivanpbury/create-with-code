using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;

    private float xRange = 10.0f;
    private float spawnPosZ = 20.0f;

    private float spawnDelay = 2.0f;
    private float spawnFrequency = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnFrequency);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Spawn animals at random locations
    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
