using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public float BulletSpeed = 1.0f;
    // Update is called once per frame
    public void Update()
    {
        MoveBySpeed();
    }

    public void MoveBySpeed()
    {
        transform.position += transform.rotation * Vector3.up * Time.deltaTime * BulletSpeed;
    }
}
