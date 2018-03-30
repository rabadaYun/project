using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : MonoBehaviour {

    float timer;
    float BoostTime;

	public void Update ()
    {
        if (Manager.Instance.GPlay)
        {
            if (Manager.Instance.UseBoost)
            {
                MoveGreen();
                timer += Time.deltaTime;
                if (timer < BoostTime)
                {
                    Manager.Instance.GreenLocationY += 0.05f;
                    if (Manager.Instance.GreenLocationY >= 3.0f)
                    {
                        Manager.Instance.GreenLocationY = 3.0f;
                    }
                }
                else
                {
                    Manager.Instance.GreenLocationY -= 0.05f;
                    if (Manager.Instance.GreenLocationY < -3.0)
                    {
                        Manager.Instance.GreenLocationY = -3.0f;
                    }
                }
            }
            else
            {
                timer = 0.0f;
                if (Manager.Instance.GreenLocationY > -3.0)
                {
                    Manager.Instance.GreenLocationY -= 0.05f;
                }
                else if (Manager.Instance.GreenLocationY < -3.0)
                {
                    Manager.Instance.GreenLocationY += 0.05f;
                }
                else
                {
                    Manager.Instance.GreenLocationY = -3.0f;
                }
                MoveGreen();
            }   
        }
    }

    public void MoveGreen()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePos.x > Manager.Instance.RightMapSize)
        {
            transform.position = new Vector3(Manager.Instance.RightMapSize, Manager.Instance.GreenLocationY, 0);
        }
        else if (mousePos.x < Manager.Instance.LeftMapSize)
        {
            transform.position = new Vector3(Manager.Instance.LeftMapSize, Manager.Instance.GreenLocationY, 0);
        }
        else
        {
            transform.position = new Vector3(mousePos.x, Manager.Instance.GreenLocationY, 0);
        }
    }

    public void Start()
    {
        timer = 0.0f;
        BoostTime = Manager.Instance.ItemDuration / 2;
    }
}
