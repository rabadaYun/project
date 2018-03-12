using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapObject : MonoBehaviour
{
    
    public float MapSpeed = 0.05f;
    private float StartPositionY = 10.0f;
    private float EndPositionY = -12.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = transform.position;
        position.y -= MapSpeed;
        if(position.y < EndPositionY)
        {
            position.y = StartPositionY;
        }
        transform.position = position;
	}
}
