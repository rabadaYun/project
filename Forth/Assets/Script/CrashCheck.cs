using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashCheck : MonoBehaviour {

    public int enemyEHealth;
    public int enemyNHealth;
    public int bulletHealth;
    public int myHealth;

    [SerializeField]
    private ItemLauncher itemLauncher = null;
    [SerializeField]
    private InGameUI inGameUI = null;

    private void Start()
    {
        enemyNHealth = Manager.Instance.EnemyNHealth;
        enemyEHealth = Manager.Instance.EnemyEHealth;
        bulletHealth = Manager.Instance.BulletHealth;
        myHealth = Manager.Instance.MyLifeCount;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        switch (gameObject.tag)
        {
            case "enemyN":
                {
                    if (collision.gameObject.tag == "Bullet")
                    {
                        Debug.Log(Manager.Instance.EnemyNHealth);
                        enemyNHealth -= Manager.Instance.BulletPower;
                        if (enemyNHealth <= 0)
                        {
                            int _randItemPer = itemLauncher.RandItemPer();
                            if (_randItemPer <= 10)
                            {
                                itemLauncher.MakePower(gameObject.transform.position);
                            }
                            else
                            {
                                itemLauncher.MakeGold(Manager.Instance.MaxGoldMake, gameObject.transform.position);
                            }
                            Destroy(gameObject);
                            inGameUI.AddKill(1);

                        }
                    }
                    else if (collision.gameObject.tag == "Player")
                    {
                        int _randItemPer = itemLauncher.RandItemPer();
                        if (_randItemPer <= 10)
                        {
                            itemLauncher.MakePower(gameObject.transform.position);
                        }
                        else
                        {
                            itemLauncher.MakeGold(Manager.Instance.MaxGoldMake, gameObject.transform.position);
                        }
                        Destroy(gameObject);
                        inGameUI.AddKill(1);
                    }
                    else if (collision.gameObject.tag == "Bullet_Boom")
                    {
                        int _randItemPer = itemLauncher.RandItemPer();
                        if (_randItemPer <= 10)
                        {
                            itemLauncher.MakePower(gameObject.transform.position);
                        }
                        else
                        {
                            itemLauncher.MakeGold(Manager.Instance.MaxGoldMake, gameObject.transform.position);
                        }
                        Destroy(gameObject);
                        inGameUI.AddKill(1);
                    }
                }
                break;
            case "enemyE":
                {
                    if (collision.gameObject.tag == "Bullet")
                    {
                        enemyEHealth -= Manager.Instance.BulletPower;
                        if (enemyEHealth <= 0)
                        {
                            int _randItemPer = itemLauncher.RandItemPer();
                            if (_randItemPer <= 10)
                            {
                                itemLauncher.MakePower(gameObject.transform.position);
                            }
                            else if (_randItemPer > 10 && _randItemPer <= 20)
                            {
                                itemLauncher.MakeBoost(gameObject.transform.position);
                            }
                            else if (_randItemPer > 20 && _randItemPer <= 30)
                            {
                                itemLauncher.MakeMagnet(gameObject.transform.position);
                            }
                            else if (_randItemPer > 30 && _randItemPer <= 40)
                            {
                                itemLauncher.MakeBoom(gameObject.transform.position);
                            }
                            else
                            {
                                itemLauncher.MakeGold(Manager.Instance.MaxGoldMake + 2, gameObject.transform.position);
                            }
                            Destroy(gameObject);
                            inGameUI.AddKill(1);
                        }
                    }
                    else if (collision.gameObject.tag == "Player")
                    {
                        int _randItemPer = itemLauncher.RandItemPer();
                        if (_randItemPer <= 10)
                        {
                            itemLauncher.MakePower(gameObject.transform.position);
                        }
                        else if (_randItemPer > 10 && _randItemPer <= 20)
                        {
                            itemLauncher.MakeBoost(gameObject.transform.position);
                        }
                        else if (_randItemPer > 20 && _randItemPer <= 30)
                        {
                            itemLauncher.MakeMagnet(gameObject.transform.position);
                        }
                        else if (_randItemPer > 30 && _randItemPer <= 40)
                        {
                            itemLauncher.MakeBoom(gameObject.transform.position);
                        }
                        else
                        {
                            itemLauncher.MakeGold(Manager.Instance.MaxGoldMake +2, gameObject.transform.position);
                        }
                        Destroy(gameObject);
                        inGameUI.AddKill(1);
                    }
                    else if (collision.gameObject.tag == "Bullet_Boom")
                    {
                        int _randItemPer = itemLauncher.RandItemPer();
                        if (_randItemPer <= 10)
                        {
                            itemLauncher.MakePower(gameObject.transform.position);
                        }
                        else if (_randItemPer > 10 && _randItemPer <= 20)
                        {
                            itemLauncher.MakeBoost(gameObject.transform.position);
                        }
                        else if (_randItemPer > 20 && _randItemPer <= 30)
                        {
                            itemLauncher.MakeMagnet(gameObject.transform.position);
                        }
                        else if (_randItemPer > 30 && _randItemPer <= 40)
                        {
                            itemLauncher.MakeBoom(gameObject.transform.position);
                        }
                        else
                        {
                            itemLauncher.MakeGold(Manager.Instance.MaxGoldMake, gameObject.transform.position);
                        }
                        Destroy(gameObject);
                        inGameUI.AddKill(1);
                    }
                }
                break;
            case "Bullet":
                {
                    if (collision.gameObject.tag == "enemyN")
                    {
                        --bulletHealth;
                        if (bulletHealth <= 0)
                        {
                            Destroy(gameObject);
                        }
                    }
                    else if (collision.gameObject.tag == "enemyE")
                    {
                        --bulletHealth;
                        if (bulletHealth <= 0)
                        {
                            Destroy(gameObject);
                        }
                    }
                }
                break;
            case "Player":
                {
                    if (collision.gameObject.tag == "enemyN")
                    {
                        if (!Manager.Instance.UseBoost)
                        {
                            --myHealth;
                            inGameUI.MinusLife(1);
                            if (myHealth <= 0)
                            {
                                Manager.Instance.GPlay = false;
                            }
                        }
                    }
                    else if (collision.gameObject.tag == "enemyE")
                    {
                        if (!Manager.Instance.UseBoost)
                        {
                            --myHealth;
                            inGameUI.MinusLife(1);
                            if (myHealth <= 0)
                            {
                                Manager.Instance.GPlay = false;
                            }
                        }
                    }
                    else if (collision.gameObject.tag == "Gold")
                    {
                        Destroy(collision.gameObject);
                        inGameUI.AddGold(1);
                    }
                    else if (collision.gameObject.tag == "Power")
                    {
                        Destroy(collision.gameObject);
                        itemLauncher.UseingPower();
                    }
                    else if (collision.gameObject.tag == "Magnet")
                    {
                        Destroy(collision.gameObject);
                        itemLauncher.UsingMagnet();
                    }
                    else if (collision.gameObject.tag == "Boost")
                    {
                        Destroy(collision.gameObject);
                        itemLauncher.UsingBoost();
                    }
                    else if (collision.gameObject.tag == "Boom")
                    {
                        Destroy(collision.gameObject);
                        itemLauncher.UsingBoom();
                    }
                }
                break;
        }
    }
}
