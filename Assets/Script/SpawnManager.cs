using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Enemies;
    public GameObject powerUp;
    private float ZSpawnRange = 10.0f;
    private float enemySpawn = 12.0f;
    private float ZpowerUpSpawnRange = 10.0f;
    private float ySpawn = 0.75f;
    private float ySpawnPowerUp = 0.70f;
    private float StartDelay = 1.0f;
    private float PowerUpspawnTime = 5.0f;
    private float EnemyspawnTime = 2.0f;

    void Start()
    {
        InvokeRepeating("spawnRandomEnemy", StartDelay, EnemyspawnTime);
        InvokeRepeating("spawnPowerUp", StartDelay, PowerUpspawnTime);
    }

    void Update()
    {
        // Additional logic can be added here if needed
    }

    private void spawnRandomEnemy()
    {
        float RandomX = Random.Range(-ZSpawnRange, ZSpawnRange);
        int RandomIndex = Random.Range(0, Enemies.Length);

        Vector3 startPros = new Vector3(RandomX, ySpawn, enemySpawn);
        GameObject instantiatedEnemy = Instantiate(Enemies[RandomIndex], startPros, Enemies[RandomIndex].transform.rotation);

        // Make the instantiated enemy face the -Z axis
        instantiatedEnemy.transform.rotation = Quaternion.LookRotation(Vector3.back);
    }

    private void spawnPowerUp()
    {
        float RandomX = Random.Range(-ZSpawnRange, ZSpawnRange);
        float RandomZ = Random.Range(-ZpowerUpSpawnRange, ZpowerUpSpawnRange);

        Vector3 startPos = new Vector3(RandomX, ySpawnPowerUp, RandomZ);
        GameObject instantiatedPowerUp = Instantiate(powerUp, startPos, powerUp.transform.rotation);

      
    }
}
