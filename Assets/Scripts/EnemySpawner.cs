using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] spawnpoins;
    public GameObject enemy;
    public float TimeBetweenSpawns;
    private float Timetospawn = 1f;

    private void Update()
    {
        if (Time.time >= Timetospawn)
        {
            Enemyspawn();
            Timetospawn = Time.time + TimeBetweenSpawns;    
        }
        
    }


    void Enemyspawn()
    {
        

        int index = Random.Range(0, spawnpoins.Length);

        Instantiate(enemy, spawnpoins[index].position, Quaternion.identity);

    }
}
