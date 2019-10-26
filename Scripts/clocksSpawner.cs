using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clocksSpawner : MonoBehaviour
{
    public GameObject clock;
    public Text lvl;
    private float[] delayArray;
    private float[] lanesxArray;

    private float hakspawnDelay;

    void Start()
    {
        delayArray = new float[3];
        delayArray[0] = 18f;
        delayArray[1] = 27f;
        delayArray[2] = 38f;
    }

    void Update()
    {
        int delay = Random.Range(0, 2);
        hakspawnDelay -= Time.deltaTime;
        if (hakspawnDelay <= -1)
        {
            // if (NextQuestionScript.lvl >= 0)
            //{
            spawnclock();
            hakspawnDelay = delayArray[delay];
            //}

        }
    }

    void spawnclock()
    {
        Instantiate(clock, new Vector3(10.28f, 2.4399991f, 0), Quaternion.identity);
    }
}
