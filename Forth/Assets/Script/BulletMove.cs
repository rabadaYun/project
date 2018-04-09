using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletMove : MonoBehaviour {

    public Vector3 Diagonal1 = new Vector3(1, 2, 0);

    public void MoveVertical()
    {
        transform.position += transform.rotation * Vector3.up * Time.deltaTime * Manager.Instance.VerticalSpeed;
    }

    public void MoveDiagonal1()
    {
        transform.position += transform.rotation * Diagonal1 * Time.deltaTime * Manager.Instance.VerticalSpeed;
    }

    public void Update()
    {
        if (Manager.Instance.GPlay)
        {
            MoveVertical();
        }
    }
    
}
