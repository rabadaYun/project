using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCar : MonoBehaviour, IGameObject {
    	
	public void GameUpdate () {
        MoveCar();
    }

    public void MoveCar()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePos.x > 1.8f)
        {
            transform.position = new Vector3(1.8f, -3f, 0);
        }
        else if (mousePos.x < -1.8f)
        {
            transform.position = new Vector3(-1.8f, -3f, 0);
        }
        else
        {
            transform.position = new Vector3(mousePos.x, -3f, 0);
        }
    }
}
