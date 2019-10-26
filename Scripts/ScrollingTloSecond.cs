using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollingTloSecond : MonoBehaviour {

    public float scrollSpeed;
    private Vector2 offset;
    public Text lvl;

    void Update()
    {
        offset = new Vector2(Time.time * scrollSpeed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
        /*if (NextQuestionScript.lvl >= 10)
        //{
            scrollSpeed = 0.1f;
        }*/
    }

}
