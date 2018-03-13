using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoad : MonoBehaviour, IGameObject
{
    [SerializeField]
    private float _startPositionY = 20.0f;
    [SerializeField]
    private float _endPositionY = -20.0f;

    public void GameUpdate () {
        MoveRoadObject();
	}

    public void MoveRoadObject()
    {
        Vector3 position = transform.position;
        position.y -= Manager.Instance.MapSpeed;
        if (position.y < _endPositionY)
        {
            position.y = _startPositionY;
        }
        transform.position = position;
    }
}
