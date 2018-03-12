using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float EnemySpeed = 1.0f;

    // Update is called once per frame
    public void Update()
    {
        EnemyMoveSpeed();
    }

    public void EnemyMoveSpeed()
    {
        transform.position += transform.rotation * Vector3.down * Time.deltaTime * EnemySpeed;
    }
}
