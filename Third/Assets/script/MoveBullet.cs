using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour {


    public void Update()
    {
        MoveBySpeed();
    }
    
    public void MoveBySpeed()
    {
        transform.position += transform.rotation * Vector3.left * Time.deltaTime * Manager.Instance.BulletSpeed;
    }
}
