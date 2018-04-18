using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletMove : MonoBehaviour {
        
    public void MoveVertical()
    {
        transform.position += transform.rotation * Vector3.up * Time.deltaTime * Manager.Instance.VerticalSpeed;
    }

    public void MoveRotation()
    {
        transform.position += transform.rotation * Vector3.up * Time.deltaTime * Manager.Instance.VerticalSpeed;
      //  transform.rotation = Quaternion.Euler(0, 1, 1);
    }

    public void Update()
    {
        if (Manager.Instance.GPlay)
        {
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                MoveVertical();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                MoveRotation();
            }
        }
    }
    
}
