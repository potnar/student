using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerHak : MonoBehaviour
{
    //public float SpawnDelay = 2.5f;
    public GameObject Hak;
    public Text lvl;
    private float[] delayArray;
    private float[] lanesxArray;

    private float hakspawnDelay;

    void Start()
    {
        delayArray = new float[5];
        delayArray[0] = 5.7f;
        delayArray[1] = 20.2f;
        delayArray[2] = 30.1f;
        delayArray[3] = 50.3f;
        delayArray[4] = 60.5f;
        lanesxArray = new float[4];
        lanesxArray[0] = 3.37f;
        lanesxArray[1] = 3.4f;
        lanesxArray[2] = 3.9f;
        lanesxArray[3] = 4.2f;
    }

    void Update()
    {
        int delay = Random.Range(0, 4);
        hakspawnDelay -= Time.deltaTime;
        if (hakspawnDelay <= 0)
        {  
            if(NextQuestionScript.lvl >= 1)
            {
                spawnhak();
                hakspawnDelay = delayArray[delay];
            }
            
        }
    }

    void spawnhak()
    {
        int lanex = Random.Range(0, 3);
        Instantiate(Hak, new Vector3(10.28f, lanesxArray[lanex], 0), Quaternion.identity);  
    }
}
