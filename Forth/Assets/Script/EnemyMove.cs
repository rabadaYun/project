using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    
	void Update ()
    {
        if (Manager.Instance.GPlay)
        {
            Move();
        }
    }

    public void Move()
    {
        gameObject.transform.position += transform.rotation * Vector3.down * Time.deltaTime * Manager.Instance.EnemySpeed;
    }
}
