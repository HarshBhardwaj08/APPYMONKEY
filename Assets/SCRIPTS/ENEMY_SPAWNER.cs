using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMY_SPAWNER : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 1f;
    public bool isSpawn = true;

    private void Start()
    {
        StartCoroutine(spawner());
    }

    IEnumerator spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (isSpawn)
        {
            yield return wait;
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
    }
}
