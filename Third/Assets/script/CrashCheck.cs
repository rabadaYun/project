using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashCheck : MonoBehaviour {
    
    public int EnemyHealth = 3;
    public int PowerEnemyHealth = 5;
    public int BulletHealth = 1;
    public int PlayerHealth = 3;

    [SerializeField]
    private ItemMake itemMake = null;
        
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
                            int _randItemPer = itemMake.RandItemPer();
                            if (_randItemPer <= 10)
                            {
                                itemMake.MakeItem1(gameObject.transform.position);
                            }
                            else
                            {
                                itemMake.MakeGold(itemMake.EnemyMaxGold, gameObject.transform.position);
                            }
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
                            int _randItemPer = itemMake.RandItemPer();
                            if (_randItemPer <= 10)
                            {
                                itemMake.MakeItem1(gameObject.transform.position);
                            }
                            else
                            {
                                itemMake.MakeGold(itemMake.PowerEnemyMaxGold, gameObject.transform.position);
                            }
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
                        Destroy(other.gameObject);
                    }
                    else if (other.gameObject.tag == "Item")
                    {
                        Debug.Log("Item!");
                        Destroy(other.gameObject);
                    }
                }
                break;
        }
    }
}