using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextQuestionScript : MonoBehaviour
{
    public static int lvl = 0;
    Text NextQuestion;
    void Start()
    {
        NextQuestion = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        NextQuestion.text = "lvl: " + lvl;
    }
}
