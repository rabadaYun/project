using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletMove : MonoBehaviour {
    
    public void MoveVertical()
    {
        transform.position += transform.rotation * Vector3.up * Time.deltaTime * Manager.Instance.VerticalSpeed;
    }

    public void Update()
    {
        if (Manager.Instance.GPlay)
        {
            MoveVertical();
        }
    }
    
}
