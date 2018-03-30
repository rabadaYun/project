using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{
    public Text goldCount;
    public Text killCount;
    public Text myLifeCount;
    public Text distance;

    void Start () {
    }
	
	void Update ()
    {
        AddDistance();
        goldCount.text = "Gold : " + Manager.Instance.GoldCount;
        killCount.text = "Kill : " + Manager.Instance.KillCount;
        myLifeCount.text = "Life : " + Manager.Instance.MyLifeCount;
        distance.text = "Distance : " + Manager.Instance.Distance.ToString("N2") + " Km";
    }

    public void AddGold(int gNum)
    {
        Manager.Instance.GoldCount += gNum;
    }

    public void AddKill(int kNum)
    {
        Manager.Instance.KillCount += kNum;
    }

    public void MinusLife(int lNum)
    {
        Manager.Instance.MyLifeCount -= lNum;
    }

    public void AddDistance()
    {
        Manager.Instance.Distance += Manager.Instance.MapSpeed * Time.deltaTime;
    }
}
