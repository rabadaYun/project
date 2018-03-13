using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGold : MonoBehaviour {


    public void Update()
    {
        MoveOnGold();
    }

    public void MoveOnGold()
    {
        float dirX = Random.Range(-15.0f, 15.0f);
        float dirY = Random.Range(-2.0f, 2.0f);
        Vector3 RanVector = new Vector3(dirX, dirY, 0);
        GetComponent<Rigidbody2D>().AddForce(RanVector);
    }
}
