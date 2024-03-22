using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;

    private float zEnemySpawn = 700.0f;
    private float xSpawnRange = 6000.0f;
    private float zPowerupRange = 700.0f;
    private float groundHeight = 44.0f; // Ajusta esto según la altura del suelo en tu juego

    private float powerupSpawnTime = 0.5f;
    private float enemySpawnTime = 1.0f;
    private float startDelay = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, enemySpawnTime);
        InvokeRepeating("SpawnPowerup", startDelay, powerupSpawnTime);
    }

    void SpawnRandomEnemy()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zEnemySpawn, zEnemySpawn);

        int randomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPos = new Vector3(randomX, groundHeight, randomZ);

        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].transform.rotation);
    }

    void SpawnPowerup()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zPowerupRange, zPowerupRange);

        Vector3 spawnPos = new Vector3(randomX, groundHeight, randomZ);

        Instantiate(powerup, spawnPos, powerup.transform.rotation);
    }
}
