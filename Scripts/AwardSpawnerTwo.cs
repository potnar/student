using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwardSpawnerTwo : MonoBehaviour
{
    public GameObject baby3;
    private float[] delay2Array;

    //private float[] lanesxArray;
    private float baby3spawnDelay;

    void Start()
    {
        delay2Array = new float[3];
        delay2Array[0] = 36.5f;
        delay2Array[1] = 10f;
        delay2Array[2] = 20f;
        
        /*lanesxArray = new float[4];
        lanesxArray[0] = -3.37f;
        lanesxArray[1] = -3.4f;
        lanesxArray[2] = -3.9f;
        lanesxArray[3] = -4.7f;*/

    }

    void Update()
    {
        int delay = Random.Range(0, 2);

        baby3spawnDelay -= Time.deltaTime;
        if (baby3spawnDelay <= -5)
        {
            spawnbaby3();
            baby3spawnDelay = delay2Array[delay];
        }

    }

    void spawnbaby3()
    {
        int lanex = Random.Range(0, 3);
        Instantiate(baby3, new Vector3(19.29f, -1.639971f, 0), Quaternion.identity);

    }

}


