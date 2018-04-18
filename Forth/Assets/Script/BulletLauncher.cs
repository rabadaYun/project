using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletLauncher : MonoBehaviour {

    public GameObject bullet_hm;
    public GameObject bullet_book;
    public GameObject boom_bullet;
    
    void Start ()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            StartCoroutine(FireBullet_1());
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            StartCoroutine(FireBullet_2());
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            StartCoroutine(FireBullet_3());
        }
    }
	
    IEnumerator FireBullet_1()
    {
        while (true)
        {
            if (Manager.Instance.PlayerLevel % 2 == 1)
            {
                Instantiate(bullet_hm, transform.position, Quaternion.identity);
            }
            else
            {
                Instantiate(bullet_hm, transform.position, Quaternion.identity);
            }
            yield return new WaitForSeconds(1 / Manager.Instance.Fps);
            if (!Manager.Instance.GPlay)
            {
                break;
            }
        }
    }

    IEnumerator FireBullet_2()
    {
        while (true)
        {
            Instantiate(bullet_book, transform.position, Quaternion.AngleAxis(-20, Vector3.forward));
            Instantiate(bullet_book, transform.position, Quaternion.AngleAxis(20, Vector3.forward));
            yield return new WaitForSeconds(2 / Manager.Instance.Fps);
            if (!Manager.Instance.GPlay)
            {
                break;
            }
        }
    }

    IEnumerator FireBullet_3()
    {
        while (true)
        {
            Instantiate(bullet_hm, transform.position, Quaternion.identity);
            Instantiate(bullet_hm, transform.position, Quaternion.AngleAxis(-30, Vector3.forward));
            Instantiate(bullet_hm, transform.position, Quaternion.AngleAxis(30, Vector3.forward));
            yield return new WaitForSeconds(3 / Manager.Instance.Fps);
            if (!Manager.Instance.GPlay)
            {
                break;
            }
        }
    }

    public void FireBoom()
    {
        Instantiate(boom_bullet, transform.position, Quaternion.identity);
    }
}
