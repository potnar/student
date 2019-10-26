using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerAward : MonoBehaviour
{
    public GameObject baby2;
    private float[] delayArray;

    //private float[] lanesxArray;
    private float baby2spawnDelay;

    void Start()
    {
        delayArray = new float[3];
        delayArray[0] = 12f;
        delayArray[1] = 32f;
        delayArray[2] = 63f;
        /*lanesxArray = new float[4];
        lanesxArray[0] = -3.37f;
        lanesxArray[1] = -3.4f;
        lanesxArray[2] = -3.9f;
        lanesxArray[3] = -4.7f;*/

    }

    void Update()
    {
        int delay = Random.Range(0, 2);
        
        baby2spawnDelay -= Time.deltaTime;
        if (baby2spawnDelay <= -7)
        {
            spawnbaby2();
            baby2spawnDelay = delayArray[delay];
        }

    }

    void spawnbaby2()
    {
        int lanex = Random.Range(0, 3);
        Instantiate(baby2, new Vector3(19.29f, -1.739971f, 0), Quaternion.identity);
        
    }
    
}
