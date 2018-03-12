using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCar : MonoBehaviour
{
    public GameObject BlackCar;
    public GameObject RedCar;
    public Vector3 SpawnPos_1;
    public Vector3 SpawnPos_2;
    public Vector3 SpawnPos_3;
    public Vector3 SpawnPos_4;
    public Vector3 SpawnPos_5;

    public float interval = 4;

    public int EnemyPoolSize = 50;
    List<GameObject> EnemyPool = new List<GameObject>();

    GameObject GenerateEnemyToPool()
    {
        GameObject[] EnemyRandCar = new GameObject[4];
        EnemyRandCar[0] = RedCar;
        EnemyRandCar[1] = RedCar;
        EnemyRandCar[2] = RedCar;
        EnemyRandCar[3] = BlackCar;

        var EnemyClone = Instantiate(EnemyRandCar[Random.Range(0, 4)]);
        
        EnemyClone.SetActive(false);
        EnemyPool.Add(EnemyClone);
        return EnemyClone;
    }


    void OnDestroy()
    {
        foreach(var EnemyClone in EnemyPool)
        {
            Destroy(EnemyClone);
        }
    }

    GameObject PopEnemyFromPool()
    {
        GameObject result = null;
        if (EnemyPool.Exists(EnemyClone => EnemyClone.activeSelf == false))
        {
            result = EnemyPool.Find(EnemyClone => EnemyClone.activeSelf==false);
        }
        else
        {
            result = GenerateEnemyToPool();
        }
        return result;
    }

    void Start () {
        for(int i = 0; i < EnemyPoolSize; ++i)
        {
            GenerateEnemyToPool();
        }
        StartCoroutine(SpawnCar());
	}
    	
    IEnumerator SpawnCar()
    {
        Vector3[] SpawnPos = new Vector3[5];
        SpawnPos[0] = SpawnPos_1;
        SpawnPos[1] = SpawnPos_2;
        SpawnPos[2] = SpawnPos_3;
        SpawnPos[3] = SpawnPos_4;
        SpawnPos[4] = SpawnPos_5;

        while (true)
        {
            for (int i = 0; i < 5; i++)
            {
                var EnemyClone = PopEnemyFromPool();
                EnemyClone.transform.position = SpawnPos[i];
                EnemyClone.SetActive(true);
            }
            yield return new WaitForSeconds(interval);

        }
    }
}
