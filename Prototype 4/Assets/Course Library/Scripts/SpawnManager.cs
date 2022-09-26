using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    private int enemyCount;
    private int nextWave = 1;
    public GameObject powerUp;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if (enemyCount == 0)
        {
            SpawnEnemies(nextWave);
            SpawnPowerUp();
            nextWave++;
        }
    }

    Vector3 GenerateSpawnPos()
    {
        float spawnPosX = Random.Range(-9, 9);
        float spawnPosZ = Random.Range(-9, 9);
        return new Vector3(spawnPosX, 0, spawnPosZ);
    }

    void SpawnEnemies(int numEnemies)
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Instantiate(enemy, GenerateSpawnPos(), enemy.transform.rotation);
        }
    }

    void SpawnPowerUp()
    {
        Instantiate(powerUp, GenerateSpawnPos(), powerUp.transform.rotation);
    }
}
