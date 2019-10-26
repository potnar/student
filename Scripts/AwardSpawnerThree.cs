using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwardSpawnerThree : MonoBehaviour
{
    public GameObject baby4;
    private float[] delayArray;

    //private float[] lanesxArray;
    private float baby4spawnDelay;

    void Start()
    {
        delayArray = new float[3];
        delayArray[0] = 27f;
        delayArray[1] = 5f;
        delayArray[2] = 41.3f;
        
        /*lanesxArray = new float[4];
        lanesxArray[0] = -3.37f;
        lanesxArray[1] = -3.4f;
        lanesxArray[2] = -3.9f;
        lanesxArray[3] = -4.7f;*/

    }

    void Update()
    {
        int delay = Random.Range(0, 2);

        baby4spawnDelay -= Time.deltaTime;
        if (baby4spawnDelay <= -1)
        {
            spawnbaby3();
            baby4spawnDelay = delayArray[delay];
        }

    }

    void spawnbaby3()
    {
        //int lanex = Random.Range(0, 3);
        Instantiate(baby4, new Vector3(19.29f, -1.639971f, 0), Quaternion.identity);

    }

}


