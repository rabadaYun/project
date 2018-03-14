using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMake : MonoBehaviour
{
    public GameObject tire;
    public GameObject item1;

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
            GameObject Gold = (GameObject)Instantiate(tire, KillPos, Quaternion.identity);
        }
    }

    public void MakeItem1(Vector3 KillPos)
    {
        GameObject Item1 = (GameObject)Instantiate(item1, KillPos, Quaternion.identity);
    }
}
