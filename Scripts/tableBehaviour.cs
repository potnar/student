using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tableBehaviour : MonoBehaviour
{
    private float EnemySpeed = 4.5f;
    public int direction = -1;
    public Text Wynik;
    public Text lvl;

    private Vector3 EnemyPosition;

    void Update()
    {
        this.gameObject.transform.Translate(new Vector3(direction, 0, 0) * EnemySpeed * Time.deltaTime);
        if (NextQuestionScript.lvl >= 10)
        {
            EnemySpeed = 7f;
        }
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
       if (obj.gameObject.tag == "endroad")
        {
            Destroy(this.gameObject);
        }
    }
}
