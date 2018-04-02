using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageUp : MonoBehaviour
{
    public void AddStage ()
    {
        Manager.Instance.EnemyNHealth += 1;
        Manager.Instance.EnemyEHealth += 2;
        Manager.Instance.MapSpeed += 0.01f;
        Manager.Instance.MaxGoldMake += 1;
        Manager.Instance.StageCount += 1;
        Manager.Instance.StageCheck = true;
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
