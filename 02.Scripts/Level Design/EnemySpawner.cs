using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemiesToSpawn;

    void Start()
    {
        InvokeRepeating("SpawnNow", 5, 3);
    }

    Vector3 getRandomPos()
    {
        float _x = Random.Range(-30, 30);
        float _y = Random.Range(2, 5);
        float _z = Random.Range(-30, 30);

        Vector3 newPos = new Vector3(_x, _y, _z);
        return newPos;
    }

    void SpawnNow()
    {
        Instantiate(enemiesToSpawn[Random.Range(0, 1)], getRandomPos(), Quaternion.identity);
    }
}
