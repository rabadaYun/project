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
                        EnemyHealth -= Manager.Instance.BulletPower;
                        if (EnemyHealth <= 0)
                        {
                            int _randItemPer = itemMake.RandItemPer();
                            if (_randItemPer <= 10)
                            {
                                itemMake.MakeItem_BulletPower(gameObject.transform.position);
                            }
                            else
                            {
                                itemMake.MakeGold(itemMake.EnemyMaxGold, gameObject.transform.position);
                            }
                            Destroy(gameObject);
                            Manager.Instance.AddKill(1);
                        }
                    }
                    else if (other.gameObject.tag == "Player")
                    {
                        int _randItemPer = itemMake.RandItemPer();
                        if (_randItemPer <= 10)
                        {
                            itemMake.MakeItem_BulletPower(gameObject.transform.position);
                        }
                        else
                        {
                            itemMake.MakeGold(itemMake.EnemyMaxGold, gameObject.transform.position);
                        }
                        Destroy(gameObject);
                        Manager.Instance.AddKill(1);
                    }
                }
                break;
            case "PowerEnemy":
                {
                    if (other.gameObject.tag == "Bullet")
                    {
                        PowerEnemyHealth -= Manager.Instance.BulletPower;
                        if (PowerEnemyHealth <= 0)
                        {
                            int _randItemPer = itemMake.RandItemPer();
                            if (_randItemPer <= 10)
                            {
                                itemMake.MakeItem_BulletPower(gameObject.transform.position);
                            }
                            else if (_randItemPer > 10 && _randItemPer <= 30)
                            {
                                itemMake.MakeItem_Boost(gameObject.transform.position);
                            }
                            else if (_randItemPer > 30 && _randItemPer <= 50)
                            {
                                itemMake.MakeItem_Magnet(gameObject.transform.position);
                            }
                            else
                            {
                                itemMake.MakeGold(itemMake.PowerEnemyMaxGold, gameObject.transform.position);
                            }
                            Destroy(gameObject);
                            Manager.Instance.AddKill(1);
                        }
                    }
                    else if (other.gameObject.tag == "Player")
                    {
                        int _randItemPer = itemMake.RandItemPer();
                        if (_randItemPer <= 10)
                        {
                            itemMake.MakeItem_BulletPower(gameObject.transform.position);
                        }
                        else if (_randItemPer > 10 && _randItemPer <= 30)
                        {
                            itemMake.MakeItem_Boost(gameObject.transform.position);
                        }
                        else if (_randItemPer > 30 && _randItemPer <= 50)
                        {
                            itemMake.MakeItem_Magnet(gameObject.transform.position);
                        }
                        else
                        {
                            itemMake.MakeGold(itemMake.PowerEnemyMaxGold, gameObject.transform.position);
                        }
                        Destroy(gameObject);
                        Manager.Instance.AddKill(1);

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
                        if (!Manager.Instance.UseItemBoost)
                        {
                            --PlayerHealth;
                            Manager.Instance.MinusLife(1);
                            if (PlayerHealth <= 0)
                            {
                                Manager.Instance.GPlay = false;
                            }
                        }
                    }
                    else if (other.gameObject.tag == "PowerEnemy")
                    {
                        if (!Manager.Instance.UseItemBoost)
                        {
                            --PlayerHealth;
                            Manager.Instance.MinusLife(1);
                            if (PlayerHealth <= 0)
                            {
                                Manager.Instance.GPlay = false;
                            }
                        }
                    }
                    else if (other.gameObject.tag == "MoveRoad1")
                    {
                        if (!Manager.Instance.UseItemBoost)
                        {
                            --PlayerHealth;
                            Manager.Instance.MinusLife(1);
                            if (PlayerHealth <= 0)
                            {
                                Manager.Instance.GPlay = false;
                            }
                        }
                    }
                    else if (other.gameObject.tag == "Gold")
                    {
                        Manager.Instance.AddGold(1);
                        Destroy(other.gameObject);
                    }
                    else if (other.gameObject.tag == "Item")
                    {
                        Destroy(other.gameObject);
                        itemMake.UseItem_BulletPower();
                    }
                    else if (other.gameObject.tag == "Item_Magnet")
                    {
                        Destroy(other.gameObject);
                        itemMake.UseItem_Magnet();
                    }
                    else if (other.gameObject.tag == "Item_Boost")
                    {
                        Destroy(other.gameObject);
                        itemMake.UseItem_Boost();
                    }
                }
                break;
        }
    }
}