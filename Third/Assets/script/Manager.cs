using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    private static Manager _instance = null;
    public static Manager Instance { get { return _instance; } }

    [SerializeField]
    private MyCar _myCar = null;
    //[SerializeField]
    //private MoveEnemy _moveEnemy= null;
    [SerializeField]
    private MoveRoad _moveRoad = null;
    

    [SerializeField]
    private float _mapSpeed = 0.05f;
    public float MapSpeed { get { return _mapSpeed; } }

    [SerializeField]
    private float _bulletSpeed = 1.0f;
    public float BulletSpeed { get { return _bulletSpeed; } }

    [SerializeField]
    private float _enemySpeed = 1.0f;
    public float EnemySpeed { get { return _enemySpeed; } }

    private bool _gPlay = false;
    public bool GPlay { get { return _gPlay; } set { _gPlay = value; } }

    public Text GoldCounter;
    private int GoldCount = 0;

    public void AddGold(int num)
    {
        GoldCount += num;
        GoldCounter.text = "Gold : " + GoldCount;
    }

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        _gPlay = true;
    }

    void Update()
    {
        if (_gPlay)
        {
            _myCar.GameUpdate();
            //_moveEnemy.GameUpdate();
            _moveRoad.GameUpdate();
        }
    }
    
}
