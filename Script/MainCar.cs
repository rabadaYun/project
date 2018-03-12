using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCar : MonoBehaviour
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(mousePos.x > 2.36f)
        {
            transform.position = new Vector3(2.36f, -4.0f, 0);
        }
        else if (mousePos.x < -2.36f)
        {
            transform.position = new Vector3(-2.36f, -4.0f, 0);
        }
        else
        {
            transform.position = new Vector3(mousePos.x, -4.0f, 0);
        }
    }
}
