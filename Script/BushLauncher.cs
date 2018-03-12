using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushLauncher : MonoBehaviour
{
    public GameObject bullet;
    public float fps = 10.0f;
    public int BulletPoolSize = 20;
    List<GameObject> BulletPool = new List<GameObject>();

	// Use this for initialization
	void Start ()
    {
        for(int i=0; i < BulletPoolSize; ++i)
        {
            GenerateBulletToPool();
        }
        StartCoroutine(Firebullet());
    }

    GameObject GenerateBulletToPool()
    {
        var BulletClone = Instantiate(bullet);
        BulletClone.SetActive(false);
        BulletPool.Add(BulletClone);
        return BulletClone;
    }

    void OnDestroy()
    {
        foreach(var BulletClone in BulletPool)
        {
            Destroy(BulletClone);
        }
    }

    GameObject PopBulletFromPool()
    {
        GameObject result = null;
        if (BulletPool.Exists(BulletClone => BulletClone.activeSelf == false))
        {
            result = BulletPool.Find(BulletClone => BulletClone.activeSelf == false);
        }
        else
        {
            result = GenerateBulletToPool();
        }
        return result;
    }

    IEnumerator Firebullet()
    {
        while (true)
        {
            var BulletClone = PopBulletFromPool();
            BulletClone.transform.position = transform.position;
            BulletClone.SetActive(true);
            yield return new WaitForSeconds(1 / fps);
        }
    }
}
