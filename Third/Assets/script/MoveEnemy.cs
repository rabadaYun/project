using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {
    public void Update()
    {
        MoveOnEnemy();
    }

    public void MoveOnEnemy()
    {
        transform.position += transform.rotation * Vector3.down * Time.deltaTime * Manager.Instance.EnemySpeed;
    }

}
