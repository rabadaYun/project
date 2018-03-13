using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashCheck : MonoBehaviour {
    
    public int EnemyHealth = 3;
    public int PowerEnemyHealth = 5;
    public int BulletHealth = 1;
    public int PlayerHealth = 3;
    //public int GoldCount = 0;
    public int EnemyMaxGold = 3;
    public int PowerEnemyMaxGold = 5;
    public GameObject tire;
    
    IEnumerator MakeGold(int MaxGold)
    {
        int GoldCount = Random.Range(1, MaxGold);

        for (int i = 0; i <= GoldCount; ++i)
        {
            Instantiate(tire, transform.position, Quaternion.identity);
        }
        yield return null;
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
                            StartCoroutine(MakeGold(EnemyMaxGold));
                            Destroy(gameObject);
                            Manager.Instance.AddKill(1);
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
                            StartCoroutine(MakeGold(PowerEnemyMaxGold));
                            Destroy(gameObject);
                            Manager.Instance.AddKill(1);
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
                        Manager.Instance.MinusLife(1);
                        if (PlayerHealth <= 0)
                        {
                            Manager.Instance.GPlay = false;
                        }
                    }
                    else if (other.gameObject.tag == "PowerEnemy")
                    {
                        --PlayerHealth;
                        Manager.Instance.MinusLife(1);
                        if (PlayerHealth <= 0)
                        {
                            Manager.Instance.GPlay = false;
                        }
                    }
                    else if (other.gameObject.tag == "MoveRoad1")
                    {
                        --PlayerHealth;
                        Manager.Instance.MinusLife(1);
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