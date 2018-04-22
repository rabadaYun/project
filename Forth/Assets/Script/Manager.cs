using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private static Manager _instance = null;
    public static Manager Instance { get { return _instance; } }
    

    //게임 시작 판정
    private bool _gPlay = false;
    public bool GPlay { set { _gPlay = value; } get { return _gPlay; } }
    //게임 일시중지
    private bool _isPause = false;
    public bool IsPause { set { _isPause = value; } get { return _isPause; } }
    //캐릭터 Y 위치
    private float _playerLocationY = -3.0f;
    public float PlayerLocationY { set { _playerLocationY = value; } get { return _playerLocationY; } }
    //플레이어 레벨
    private int _playerLevel = 1;
    public int PlayerLevel { set { _playerLevel = value; } get { return _playerLevel; } }
    //맵 왼쪽 사이즈
    private float _leftMapSize = -2.55f;
    public float LeftMapSize { get { return _leftMapSize; } }
    //맵 오른쪽 사이즈
    private float _rightMapSize = 2.55f;
    public float RightMapSize { get { return _rightMapSize; } }
    //순환 맵 제일 위 좌표
    private float _startPositionY = 10.0f;
    public float StartPositionY { get { return _startPositionY; } }
    //순환 맵 제일 아래 좌표
    private float _endPositionY = -10.0f;
    public float EndPositionY { get { return _endPositionY; } }
    //순환 맵 이동 속도
    private float _mapSpeed = 0.05f;
    public float MapSpeed { set { _mapSpeed = value; } get { return _mapSpeed; } }
    //총알 시간당 발사량
    private float _fps = 5.0f;
    public float Fps { set { _fps = value; } get { return _fps; } }
    //총알 이동 속도
    private float _verticalSpeed = 3.0f;
    public float VerticalSpeed { set { _verticalSpeed = value; } get { return _verticalSpeed; } }
    //총알 한발당 파워
    private int _bulletPower = 10;
    public int BulletPower { set { _bulletPower = value; } get { return _bulletPower; } }
    //총알 체력
    private int _bulletHealth = 1;
    public int BulletHealth { set { _bulletHealth = value;  } get { return _bulletHealth; } }
    //적 이동 속도
    private float _enemySpeed = 1.0f;
    public float EnemySpeed { set { _enemySpeed = value; } get { return _enemySpeed; } }
    //적 생성 시간
    private float _interval = 4.0f;
    public float Interval { set { _interval = value; } get { return _interval; } }
    //일반 적 체력
    private int _enemyNHealth = 30;
    public int EnemyNHealth { set { _enemyNHealth = value;  } get { return _enemyNHealth; } }
    //엘리트 적 체력
    private int _enemyEHealth = 50;
    public int EnemyEHealth { set { _enemyEHealth = value; } get { return _enemyEHealth; } }
    //슈퍼 엘리트 적 체력
    private int _enemySEHealth = 100;
    public int EnemySEHealth { set { _enemySEHealth = value; } get { return _enemySEHealth; } }
    //골드 최대 생성량
    private int _maxGoldMake = 3;
    public int MaxGoldMake { set { _maxGoldMake = value; } get { return _maxGoldMake; } }
    //아이템 지속시간
    private float _itemDuration = 5;
    public float ItemDuration { set { _itemDuration = value; } get { return _itemDuration; } }
    //자석아이템 사용여부
    private bool _useMagnet = false;
    public bool UseMagnet { set { _useMagnet = value; } get { return _useMagnet; } }
    //부스트아이템 사용여부
    private bool _useBoost = false;
    public bool UseBoost { set { _useBoost = value; } get { return _useBoost; } }

    // UI
    //골드 카운트
    private int _goldCount = 0;
    public int GoldCount { set { _goldCount = value; } get { return _goldCount; } }
    //킬 카운트
    private int _killCount = 0;
    public int KillCount { set { _killCount = value; } get { return _killCount; } }
    //플레이어 체력
    private int _myLifeCount = 3;
    public int MyLifeCount { set { _myLifeCount = value; } get { return _myLifeCount; } }
    //이동 거리
    private float _distance = 0.0f;
    public float Distance { set { _distance = value; } get { return _distance; } }
    //스테이지 카운트
    private int _stageCount = 0;
    public int StageCount { set { _stageCount = value; } get { return _stageCount; } }

    //스테이지 체크
    private bool _stageCheck = false;
    public bool StageCheck { set { _stageCheck = value; } get { return _stageCheck; } }
    
    public void UIReset()
    {
        _goldCount = 0;
        _killCount = 0;
        _myLifeCount = 3;
        _distance = 0;
    }

    private void Awake()
    {
        _instance = this;
    }
    
    void Start () {
        _gPlay = true;

        UIReset();
    }
	
	void Update ()
    {

	}
}
