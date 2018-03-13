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
        float dir1 = Random.Range(-1f, 1f);
        float dir2 = Random.Range(0, 2f);
        Vector3 RanVector = new Vector3(dir1, dir2, 0);
        transform.position += transform.rotation * RanVector * Time.deltaTime;
    }
}
