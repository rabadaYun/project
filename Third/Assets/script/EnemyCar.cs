using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCar : MonoBehaviour
{
    public GameObject PowerEnemy;
    public GameObject Enemy;
    
    public Vector3 SpawnPos_1 = new Vector3(-2.8f,7,0);
    public Vector3 SpawnPos_2 = new Vector3(-1.4f, 7, 0);
    public Vector3 SpawnPos_3 = new Vector3(-0f, 7, 0);
    public Vector3 SpawnPos_4 = new Vector3(1.4f, 7, 0);
    public Vector3 SpawnPos_5 = new Vector3(2.8f, 7, 0);

    public float interval = 4;

    public GameObject[] EnemyRandCar = new GameObject[4];

    void Start()
    {
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

        EnemyRandCar[0] = Enemy;
        EnemyRandCar[1] = Enemy;
        EnemyRandCar[2] = Enemy;
        EnemyRandCar[3] = PowerEnemy;
        
        while (true)
        {
            for (int i = 0; i <= 4; i++)
            {
                Instantiate(EnemyRandCar[Random.Range(0, 4)], SpawnPos[i], Quaternion.LookRotation(Vector3.forward));
            }
            yield return new WaitForSeconds(interval);
        }
        
    }
}
