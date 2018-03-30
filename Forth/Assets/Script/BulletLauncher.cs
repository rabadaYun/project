using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour {

    public GameObject bullet;
    public GameObject boom;

	void Start () {
        StartCoroutine(FireBullet());
	}
	
    IEnumerator FireBullet()
    {
        while (true)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1 / Manager.Instance.Fps);
            if (!Manager.Instance.GPlay)
            {
                break;
            }
        }
    }

    public void FireBoom()
    {
        Instantiate(boom, transform.position, Quaternion.identity);
    }
}
