using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    //public float SpawnDelay = 2f;
    public GameObject Enemy;

    public float[] delayArray;

    private float EnemyspawnDelay;

    void Start()
    {
        delayArray = new float[3];
        delayArray[0] = 52f;
        delayArray[1] = 5.5f;
        delayArray[2] =100f;
        
    }

    void Update()
    {
        int delay = Random.Range(0, 2);
        EnemyspawnDelay -= Time.deltaTime;
        if (EnemyspawnDelay <= -15)
        {
            EnemyspawnDelay = delayArray[delay];
            spawnEnemy();
        }
       
    }

    void spawnEnemy()
    {
        Instantiate(Enemy, new Vector3(10.5f, -3.160601f, 0), Quaternion.identity);       
    }
    
}
