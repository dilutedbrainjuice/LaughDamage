using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject enemyPrefab2;
    public GameObject enemyPrefab3;

    public float spawnRadius = 10f;
    private int currentWave = 0;
    public Vector3 offset;
    public Vector3 spawnPosition;

    void Start()
    {
        StartNextWave();
    }

    void StartNextWave()
    {
        StartCoroutine(SpawnWave());
        currentWave++;
    }

    IEnumerator SpawnWave()
    {
        for (int i = 0; i < currentWave * 2; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(1f);
        }

        Debug.Log("Wave " + currentWave + " completed!");

        yield return new WaitForSeconds(5f);
        StartNextWave();
    }

    void SpawnEnemy()
    {
        // Calculate a random spawn position within a circle (2D example)
        Vector2 randomCirclePos = Random.insideUnitCircle * spawnRadius;
        spawnPosition = new Vector3(randomCirclePos.x, 0f, randomCirclePos.y) + transform.position + offset;

        int randomPrefabIndex = Random.Range(0, 3);
        RandomSpawn(randomPrefabIndex);
        // Instantiate the chosen enemy prefab at the random spawn position
        
    }

    void RandomSpawn(int randomInt)
    {
        switch (randomInt)
        {
            case 0:
                Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
                break;

            case 1:
                Instantiate(enemyPrefab2, spawnPosition, Quaternion.identity);
                break;

            case 2:
                Instantiate(enemyPrefab3, spawnPosition, Quaternion.identity);
                break;


        }
    }

}
