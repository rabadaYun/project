using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCar : MonoBehaviour, IGameObject {
    	
    private float LeftRoadSize = -2.8f;
    private float RightRoadSize = 2.8f;

    public void GameUpdate() {
        if (!Manager.Instance.UseItemBoost)
        {
            if (Manager.Instance.CarRotationY > -4.0f)
            {
                Manager.Instance.CarRotationY -= 0.04f;
            
            }
            else if (Manager.Instance.CarRotationY < -4.0f)
            {
                Manager.Instance.CarRotationY = -4.0f;
            }
            MoveCar();
        }
        else
        {
            if (Manager.Instance.CarRotationY >= 2.0f)
            {
                Manager.Instance.CarRotationY = 2.0f;
            }
            else if (Manager.Instance.CarRotationY <= -4.0f)
            {
                Manager.Instance.CarRotationY = -4.0f;
            }
                Manager.Instance.CarRotationY += 0.04f;
                MoveCarBoost();
            
        }
    }

    public void MoveCar()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
            if (mousePos.x > RightRoadSize)
            {
                transform.position = new Vector3(RightRoadSize, Manager.Instance.CarRotationY, 0);
                
            }
            else if (mousePos.x < LeftRoadSize)
            {
                transform.position = new Vector3(LeftRoadSize, Manager.Instance.CarRotationY, 0);
                
            }
            else
            {
                transform.position = new Vector3(mousePos.x, Manager.Instance.CarRotationY, 0);
                
            }
    }
    public void MoveCarBoost()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePos.x > RightRoadSize)
        {
            transform.position = new Vector3(RightRoadSize, Manager.Instance.CarRotationY, 0);
        }
        else if (mousePos.x < LeftRoadSize)
        {
            transform.position = new Vector3(LeftRoadSize, Manager.Instance.CarRotationY, 0);
        }
        else
        {
            transform.position = new Vector3(mousePos.x, Manager.Instance.CarRotationY, 0);
        }
    }
}
