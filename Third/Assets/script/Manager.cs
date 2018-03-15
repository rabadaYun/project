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
   // [SerializeField]
  //  private ItemMake _itemMake= null;
    [SerializeField]
    private MoveRoad _moveRoad = null;
    
    [SerializeField]
    private float _mapSpeed = 0.05f;
    public float MapSpeed { set { _mapSpeed = value; } get { return _mapSpeed; } }
    
    [SerializeField]
    private float _bulletSpeed = 1.0f;
    public float BulletSpeed { set { _bulletSpeed = value; } get { return _bulletSpeed; } }

    [SerializeField]
    private int _bulletPower = 2;
    public int BulletPower { set { _bulletPower = value; } get { return _bulletPower; } }

    [SerializeField]
    private float _enemySpeed = 1.0f;
    public float EnemySpeed { set { _enemySpeed = value; } get { return _enemySpeed; } }

    [SerializeField]
    private float _itemUseTime = 5.0f;
    public float ItemUseTime { get { return _itemUseTime; } }

    [SerializeField]
    private int _enemyHealth = 3;
    public int EnemyHealth { set { _enemyHealth = value; } get { return _enemyHealth; } }

    [SerializeField]
    private float _carRotationY = -4.0f;
    public float CarRotationY { set { _carRotationY = value; } get { return _carRotationY; } }

    private bool _useItemMagnet = false;
    public bool UseItemMagnet { set { _useItemMagnet = value; } get { return _useItemMagnet; } }
    
    public bool _useItemBoost = false;
    public bool UseItemBoost { set { _useItemBoost = value; } get { return _useItemBoost; } }

    private bool _gPlay = false;
    public bool GPlay { set { _gPlay = value; } get { return _gPlay; } }
    
    public Text _goldCount;
    private int GoldCount = 0;

    public Text _killCount;
    private int KillCount = 0;

    public Text _myLifeCount;
    private int MyLifeCount = 3;

    public Text _distance;
    private float Distance = 0.0f;

    public void AddGold(int gNum)
    {
        GoldCount += gNum;
        _goldCount.text = "Gold : " + GoldCount;
    }

    public void AddKill(int kNum)
    {
        KillCount += kNum;
        _killCount.text = "Kill : " + KillCount;
    }

    public void MinusLife(int lNum)
    {
        MyLifeCount -= lNum;
        _myLifeCount.text = "Life : " + MyLifeCount;
    }

    public void AddDistance()
    {
        Distance += MapSpeed * Time.deltaTime;
        string tempString = Distance.ToString("N2");
        _distance.text = "Distance : " + tempString + " Km";
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
       //     _itemMake.GameUpdate();
            _moveRoad.GameUpdate();
            AddDistance();
        }
    }
    
}
