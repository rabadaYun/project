using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashCheck : MonoBehaviour
{
    public int health = 5;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        --health;
        if(health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
