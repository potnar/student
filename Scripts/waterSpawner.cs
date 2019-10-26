using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waterSpawner : MonoBehaviour
{
    public GameObject banana;
    private float[] delayArray;

    //private float[] lanesxArray;
    private float baby2spawnDelay;

    void Start()
    {
        delayArray = new float[3];
        delayArray[0] = 8f;
        delayArray[1] = 28f;
        delayArray[2] = 13f;
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
        if (baby2spawnDelay <= -15)
        {
            spawnbaby2();
            baby2spawnDelay = delayArray[delay];
        }

    }

    void spawnbaby2()
    {
        int lanex = Random.Range(0, 3);
        Instantiate(banana, new Vector3(17.29f, -4.121f, 0), Quaternion.identity);
        
    }
    
}
