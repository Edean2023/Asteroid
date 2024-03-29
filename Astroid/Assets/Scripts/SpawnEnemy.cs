﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemeyPrefab;

     public float spawnDistance = 10;

    float enemyRate = 10;
    float nextEnemy = 1;

    // Update is called once per frame
    void Update()
    {
        nextEnemy -= Time.deltaTime;
      if(nextEnemy <= 0)
        {
            nextEnemy = enemyRate;
            enemyRate *= 1f;

            Vector3 offset = Random.onUnitSphere;

            offset.z = 0;

            offset = offset.normalized * spawnDistance;

            Instantiate(enemeyPrefab, transform.position + offset, Quaternion.identity);
        }  
    }
}
