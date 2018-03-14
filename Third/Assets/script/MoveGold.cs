using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGold : MonoBehaviour {
    

    public void Update()
    {
        MoveOnGold();

        this.gameObject.transform.Rotate(0, 5, 0);
    }

    public void MoveOnGold()
    {
        float dirX = Random.Range(-10.0f, 10.0f);
        float dirY = Random.Range(0f, 2.0f);
        Vector3 RanVector = new Vector3(dirX, dirY, 0);
        GetComponent<Rigidbody2D>().AddForce(RanVector);
    }
}
