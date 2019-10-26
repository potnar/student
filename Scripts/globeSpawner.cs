using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clockSpawner : MonoBehaviour
{
    public GameObject clock;
    public Text lvl;
    private float[] delayArray;
    private float[] lanesxArray;

    private float hakspawnDelay;

    void Start()
    {
        delayArray = new float[3];
        delayArray[0] = 12f;
        delayArray[1] = 10f;
        delayArray[2] = 20f;
        lanesxArray = new float[4];
        lanesxArray[0] = 3.37f;
        lanesxArray[1] = 3.4f;
        lanesxArray[2] = 3.9f;
        lanesxArray[3] = 4.2f;
    }

    void Update()
    {
        int delay = Random.Range(0, 2);
        hakspawnDelay -= Time.deltaTime;
        if (hakspawnDelay <= 0)
        {
            if (NextQuestionScript.lvl >= 1)
            {
                spawnclock();
                hakspawnDelay = delayArray[delay];
            }

        }
    }

    void spawnclock()
    {
        int lanex = Random.Range(0, 3);
        Instantiate(clock, new Vector3(15.28f, 2.1f, 0), Quaternion.identity);
    }
}
