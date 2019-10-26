using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamePoint : MonoBehaviour {

    public static float wynik = 0;
    Text Points;
	void Start ()
    {
        Points = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        Points.text = wynik.ToString("n0");
	}
}
