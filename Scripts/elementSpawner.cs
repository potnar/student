using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elementSpawner : MonoBehaviour {

    //public float SpawnDelay = 2f;
    public GameObject tablica;

    public float[] delayArray;
    private float[] lanesArray;

    private float EnemyspawnDelay;

    void Start()
    {
        delayArray = new float[5];
        delayArray[0] = 23f;
        delayArray[1] = 30f;
        delayArray[2] = 4f;
        delayArray[3] = 14f;
        delayArray[4] = 9f;

    }

    void Update()
    {
        int delay = Random.Range(0, 4);
        EnemyspawnDelay -= Time.deltaTime;
        if (EnemyspawnDelay <= 0)
        {
            spawnEnemy();
            EnemyspawnDelay = delayArray[delay];
        }
       
    }

    void spawnEnemy()
    {
        Instantiate(tablica, new Vector3(12.5f, 0.160601f, 0), Quaternion.identity);       
    }
  
}
