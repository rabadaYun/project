using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{
    void Start () {
		
	}

    public void MoveRoadObject()
    {
        Vector3 position = transform.position;
        position.y -= Manager.Instance.MapSpeed;
        if (position.y < Manager.Instance.EndPositionY)
        {
            position.y = Manager.Instance.StartPositionY;
        }
        transform.position = position;
    }

    public void Update()
    {
        MoveRoadObject();
    }
}
