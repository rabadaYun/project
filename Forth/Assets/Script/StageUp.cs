using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageUp : MonoBehaviour
{
    public GameObject EnemySE;

    public void AddStage ()
    {
        int RandSpownSE = Random.Range(-2, 2);
        Vector3 SpownSE = new Vector3(RandSpownSE, 7, 0);
        Manager.Instance.EnemyNHealth += 5;
        Manager.Instance.EnemyEHealth += 10;
        Manager.Instance.EnemySEHealth += 30;
        Manager.Instance.MapSpeed += 0.01f;
        Manager.Instance.MaxGoldMake += 1;
        Manager.Instance.StageCount += 1;
        Manager.Instance.StageCheck = true;
        Instantiate(EnemySE, SpownSE, Quaternion.identity);
    }

    public string ReturnStageCount()
    {        
        return Manager.Instance.Distance.ToString("N2");
    }

    public bool ReturnStageCheck()
    {        
        return Manager.Instance.StageCheck = false;
    }    

    private void Update()
    {
        if (Mathf.Floor(Manager.Instance.Distance) % 2 == 0 && Manager.Instance.StageCheck == false)
        {
            AddStage();
            Debug.Log("Stage: " + Manager.Instance.StageCount);
            Invoke("ReturnStageCheck", 10);
        }
    }
}
