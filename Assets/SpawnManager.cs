using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRadius = 10f;
    private int currentWave = 0;
    public Vector3 offset;

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
        Vector3 spawnPosition = new Vector3(randomCirclePos.x, 0f, randomCirclePos.y) + transform.position + offset;

        // Instantiate the chosen enemy prefab at the random spawn position
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }

}
