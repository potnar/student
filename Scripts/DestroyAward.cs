using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAward : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        if (obj.gameObject.tag == "endroad")
        {
            Destroy(this.gameObject);
        }
    }

}
