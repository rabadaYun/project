using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCar : MonoBehaviour, IGameObject {
    	
    private float LeftRoadSize = -2.8f;
    private float RightRoadSize = 2.8f;
    private float CarRotationY = -4.0f;
    
	public void GameUpdate () {
        MoveCar();
    }

    public void MoveCar()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePos.x > RightRoadSize)
        {
            transform.position = new Vector3(RightRoadSize, CarRotationY, 0);
        }
        else if (mousePos.x < LeftRoadSize)
        {
            transform.position = new Vector3(LeftRoadSize, CarRotationY, 0);
        }
        else
        {
            transform.position = new Vector3(mousePos.x, CarRotationY, 0);
        }
    }
}
