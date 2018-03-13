using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRemover : MonoBehaviour {
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "PowerEnemy")
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Gold")
        {
            Destroy(other.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "PowerEnemy")
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Gold")
        {
            Destroy(other.gameObject);
        }
    }
}
