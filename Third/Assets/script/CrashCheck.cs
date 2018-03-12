using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashCheck : MonoBehaviour {
    
    public int EnemyHealth = 3;
    public int PowerEnemyHealth = 5;
    public int BulletHealth = 1;
    public int PlayerHealth = 3;

    void OnTriggerEnter2D(Collider2D other)
    {
        switch(gameObject.tag)
        {
            case "Enemy":
                {
                    --EnemyHealth;
                    if (EnemyHealth <= 0)
                    {
                        Destroy(gameObject);
                    }
                }
                break;
            case "PowerEnemy":
                {
                    --PowerEnemyHealth;
                    if (PowerEnemyHealth <= 0)
                    {
                        Destroy(gameObject);
                    }
                }
                break;
            case "Bullet":
                {
                    if (other.gameObject.tag != "Player")
                    {
                        --BulletHealth;
                        if (BulletHealth <= 0)
                        {
                            gameObject.SetActive(false);
                        }
                    }
                }
                break;
            case "Player":
                { if(other.gameObject.tag != "Bullet")
                    {
                        --PlayerHealth;
                        if (PlayerHealth <= 0)
                        {
                            Manager.Instance.GPlay = false;
                        }
                    }
                }
                break;
        }
    }
}