using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLauncher : MonoBehaviour {

    public GameObject Gold;
    public GameObject Boost;
    public GameObject Magnet;
    public GameObject Power;
    public GameObject Boom;
    
    [SerializeField]
    private BulletLauncher bulletLauncher = null;

    public int RandItemPer()
    {
        int randomItem = Random.Range(1, 100);
        return randomItem;
    }
    
    public void MakeGold(int MaxGold, Vector3 KillPos)
    {
        int GoldCount = Random.Range(1, MaxGold);
        for (int i = 1; i <= GoldCount; i++)
        {
            Instantiate(Gold, KillPos, Quaternion.identity);
        }
    }

    public void MakePower(Vector3 KillPos)
    {
        Instantiate(Power, KillPos, Quaternion.identity);
    }

    public void UseingPower()
    {
        Manager.Instance.BulletPower += 1;
        Invoke("RevokePower", Manager.Instance.ItemDuration);
    }

    public void RevokePower()
    {
        Manager.Instance.BulletPower -= 1;
    }

    public void MakeMagnet(Vector3 KillPos)
    {
        Instantiate(Magnet, KillPos, Quaternion.identity);
    }

    public void UsingMagnet()
    {
        if (Manager.Instance.UseMagnet == true)
        {
            var PlusTime = Manager.Instance.ItemDuration + 3;
            Invoke("RevokeMagnet", PlusTime);
        }
        else
        {
            Manager.Instance.UseMagnet = true;
            Invoke("RevokeMagnet", Manager.Instance.ItemDuration);
        }
    }

    public void RevokeMagnet()
    {
        Manager.Instance.UseMagnet = false;
    }

    public void MakeBoost(Vector3 KillPos)
    {
        Instantiate(Boost, KillPos, Quaternion.identity);
    }

    public void UsingBoost()
    {
        if (Manager.Instance.UseBoost == true)
        {
            var PlusTime = Manager.Instance.ItemDuration + 1.0f;
            Manager.Instance.MapSpeed += 0.1f;
            Manager.Instance.EnemySpeed += 1.0f;
            Invoke("RevokeBoost", PlusTime);
        }
        else
        {
            Manager.Instance.UseBoost = true;
            Manager.Instance.MapSpeed += 0.1f;
            Manager.Instance.EnemySpeed += 1.0f;
            Invoke("RevokeBoost", Manager.Instance.ItemDuration);
        }
    }
    
    public void RevokeBoost()
    {
        Manager.Instance.UseBoost = false;
        Manager.Instance.MapSpeed -= 0.1f;
        Manager.Instance.EnemySpeed -= 1.0f;
    }

    public void MakeBoom(Vector3 KillPos)
    {
        Instantiate(Boom, KillPos, Quaternion.identity);
    }

    public void UsingBoom()
    {
        bulletLauncher.FireBoom();
    }
}
