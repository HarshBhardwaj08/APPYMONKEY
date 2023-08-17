using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMY_SPAWNER : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 2f;
    public Vector2 spawnArea;

    private float spawnTimer = 0f;

    private void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnRate)
        {
            SpawnEnemy();
            spawnTimer = 0f;
        }
    }

    private void SpawnEnemy()
    {
        Vector2 spawnPosition = new Vector2(
            Random.Range(-spawnArea.x/2 , spawnArea.x/2 ),
            Random.Range(-spawnArea.y/2, spawnArea.y/2)
        );

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
