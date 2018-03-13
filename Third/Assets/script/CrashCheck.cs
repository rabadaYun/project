using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashCheck : MonoBehaviour {
    
    public int EnemyHealth = 3;
    public int PowerEnemyHealth = 5;
    public int BulletHealth = 1;
    public int PlayerHealth = 3;
    public int GoldCount = 0;
    public GameObject tire;
    

    void MakeGold()
    {
        float dir1 = Random.Range(-1f, 1f);
        float dir2 = Random.Range(0, 2f);
        Vector3 RanVector = new Vector3(dir1, dir2, 0);

        int GoldCount = Random.Range(1, 4);
        for (int i = 0; i < GoldCount; ++i) 
        {
            Instantiate(tire, transform.position, Quaternion.LookRotation(RanVector));
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch(gameObject.tag)
        {
            case "Enemy":
                {
                    if (other.gameObject.tag == "Bullet")
                    {
                        --EnemyHealth;
                        if (EnemyHealth <= 0)
                        {
                            Destroy(gameObject);
                        }
                    }
                }
                break;
            case "PowerEnemy":
                {
                    if (other.gameObject.tag == "Bullet")
                    {
                        --PowerEnemyHealth;
                        if (PowerEnemyHealth <= 0)
                        {
                            Destroy(gameObject);
                        }
                    }
                }
                break;
            case "Bullet":
                {
                    if (other.gameObject.tag == "Enemy")
                    {
                        --BulletHealth;
                        if (BulletHealth <= 0)
                        {
                            gameObject.SetActive(false);
                        }
                    }
                    else if (other.gameObject.tag == "PowerEnemy")
                    {
                        --BulletHealth;
                        if (BulletHealth <= 0)
                        {
                            gameObject.SetActive(false);
                        }
                    }
                }
                break;
            case "Gold":
                {
                    if(other.gameObject.tag == "Player")
                    {
                        gameObject.SetActive(false);
                    }
                }
                break;
            case "Player":
                {
                    if (other.gameObject.tag == "Enemy")
                    {
                        --PlayerHealth;
                        if (PlayerHealth <= 0)
                        {
                            Manager.Instance.GPlay = false;
                        }
                    }
                    else if (other.gameObject.tag == "PowerEnemy")
                    {
                        --PlayerHealth;
                        if (PlayerHealth <= 0)
                        {
                            Manager.Instance.GPlay = false;
                        }
                    }
                    else if (other.gameObject.tag == "MoveRoad1")
                    {
                        --PlayerHealth;
                        if (PlayerHealth <= 0)
                        {
                            Manager.Instance.GPlay = false;
                        }
                    }
                    else if (other.gameObject.tag == "Gold")
                    {
                        Manager.Instance.AddGold(1);
                        other.gameObject.SetActive(false);
                    }
                }
                break;
        }
    }
}