using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class elementBehaviour : MonoBehaviour
{
    
    private float awardSpeed = 0.8f;
   

    public Text lvl;
    private Vector3 EnemyPosition;
   //public Animator bubbleAnim;
    

    void Update()
    {
        this.gameObject.transform.Translate(new Vector3(-2.5f, 0f, 0f) * awardSpeed * Time.deltaTime);
      
           //bubbleAnim.SetTrigger("bubble");
       
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        
        if (obj.gameObject.tag == "endOfRoadAward")
        {
            Destroy(this.gameObject);
        }
    }
}