using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGold : MonoBehaviour {
    
    public GameObject MyCar = null;
    public Vector3 GoingGold;

    public void Update()
    {
        MoveOnGold();
        if (Manager.Instance.UseItemMagnet)
        {
            MoveToCar();
        }
        this.gameObject.transform.Rotate(0, 5, 0);
    }

    public void MoveOnGold()
    {
        float dirX = Random.Range(-10.0f, 10.0f);
        float dirY = Random.Range(0f, 2.0f);
        Vector3 RanVector = new Vector3(dirX, dirY, 0);
        GetComponent<Rigidbody2D>().AddForce(RanVector);
    }

    public void MoveToCar()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GoingGold = new Vector3(mousePos.x, Manager.Instance.CarRotationY, 0);
        Vector3 GoldPos = Vector3.MoveTowards(this.gameObject.transform.position, GoingGold, Time.deltaTime*10.0f);
        transform.position = GoldPos;
    }
}
