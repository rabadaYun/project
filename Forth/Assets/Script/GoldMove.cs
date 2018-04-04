using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldMove : MonoBehaviour
{
    public GameObject Green;
    public GameObject Yellow;
    public GameObject Blue;

    public Vector3 GoldVector;

	void Update ()
    {
        MoveNormal();
        if (Manager.Instance.UseMagnet)
        {
            MoveMagnet();
        }
        gameObject.transform.Rotate(0, 5, 0);
	}

    public void MoveNormal()
    {
        float dirX = Random.Range(-10.0f, 10.0f);
        float dirY = Random.Range(0f, 2.0f);
        Vector3 RanVector = new Vector3(dirX, dirY, 0);
        GetComponent<Rigidbody2D>().AddForce(RanVector);
    }

    public void MoveMagnet()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GoldVector = new Vector3(mousePos.x, Manager.Instance.PlayerLocationY, 0);
        Vector3 GoldPos = Vector3.MoveTowards(this.gameObject.transform.position, GoldVector, Time.deltaTime * 10.0f);
        transform.position = GoldPos;
    }
}
