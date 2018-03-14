using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {
    public void Update()
    {
        if (Manager.Instance.GPlay)
        {
            MoveOnEnemy();
        }
    }

    public void MoveOnEnemy()
    {
        this.gameObject.transform.position += transform.rotation * Vector3.down * Time.deltaTime * Manager.Instance.EnemySpeed;
    }

}
