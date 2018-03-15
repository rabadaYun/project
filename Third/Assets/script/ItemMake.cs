using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMake : MonoBehaviour
{
    public GameObject tire;
    public GameObject item_BulletPower;
    public GameObject item_Magnet;
    public GameObject item_Boost;

    public int EnemyMaxGold = 3;
    public int PowerEnemyMaxGold = 5;
        
    public int RandItemPer()
    {
        int randomItem = Random.Range(0, 100);
        return randomItem;
    }

    public void MakeGold(int MaxGold, Vector3 KillPos)
    {
        int GoldCount = Random.Range(1, MaxGold);

        for (int i = 0; i <= GoldCount; ++i)
        {
            Instantiate(tire, KillPos, Quaternion.identity);
        }
    }

    public void MakeItem_BulletPower(Vector3 KillPos)
    {
        Instantiate(item_BulletPower, KillPos, Quaternion.identity);
    }
    
    public void UseItem_BulletPower()
    {
        ++Manager.Instance.BulletPower;
        Invoke("RevokeItemStat_BulletPower", Manager.Instance.ItemUseTime);
    }

    public void RevokeItemStat_BulletPower()
    {
        --Manager.Instance.BulletPower;        
    }

    public void MakeItem_Magnet(Vector3 KillPos)
    {
        Instantiate(item_Magnet, KillPos, Quaternion.identity);
    }

    public void UseItem_Magnet()
    {
        Manager.Instance.UseItemMagnet = true;
        Invoke("RevokeItemStat_Magnet", Manager.Instance.ItemUseTime);
    }

    public void RevokeItemStat_Magnet()
    {
        Manager.Instance.UseItemMagnet = false;
    }

    public void MakeItem_Boost(Vector3 KillPos)
    {
        Instantiate(item_Boost, KillPos, Quaternion.identity);
    }

    public void UseItem_Boost()
    {
        Manager.Instance.UseItemBoost = true;
        Manager.Instance.MapSpeed += 0.1f;
        Manager.Instance.EnemySpeed += 1.0f;
        Invoke("RevokeItemStat_Boost", Manager.Instance.ItemUseTime);
    }

    public void RevokeItemStat_Boost()
    {
        Manager.Instance.MapSpeed -= 0.1f;
        Manager.Instance.EnemySpeed -= 1.0f;
        Manager.Instance.UseItemBoost = false;
    }
}
