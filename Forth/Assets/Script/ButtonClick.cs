using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public static int characterNumber = 1;
    public GameObject UpgradePop;

    public GameObject oldBullet;
    public GameObject newBullet;

    public void UpgradeButton()
    {
        if (!Manager.Instance.IsPause)
        {
            Time.timeScale = 0;
            Manager.Instance.IsPause = true;
            Text UpgradeText = GameObject.Find("UpgradeText").GetComponent<Text>();
            UpgradeText.text = "Return";
        }
        else
        {
            Time.timeScale = 1;
            Manager.Instance.IsPause = false;
            Text UpgradeText = GameObject.Find("UpgradeText").GetComponent<Text>();
            UpgradeText.text = "Upgrade";
        }
    }

    public void CheckPlayerLevel()
    {
        if (Manager.Instance.PlayerLevel == 1)
        {
            oldBullet.GetComponent<Image>().sprite = Resources.Load("Make/hm1", typeof(Sprite)) as Sprite;
            newBullet.GetComponent<Image>().sprite = Resources.Load("Arrow_front", typeof(Sprite)) as Sprite;
        }
        else if (Manager.Instance.PlayerLevel == 2)
        {
            newBullet.GetComponent<Image>().sprite = Resources.Load("Make/hm1", typeof(Sprite)) as Sprite;
            oldBullet.GetComponent<Image>().sprite = Resources.Load("Arrow_front", typeof(Sprite)) as Sprite;
        }
        else
        {
            newBullet.GetComponent<Image>().sprite = Resources.Load("Make/hm1", typeof(Sprite)) as Sprite;
            oldBullet.GetComponent<Image>().sprite = Resources.Load("Make/hm1", typeof(Sprite)) as Sprite;
        }
    }

    public void UpgradeBullet()
    {
        CheckPlayerLevel();
        Debug.Log(Manager.Instance.PlayerLevel);
        Debug.Log("BulletUpgrade!");
        if (Manager.Instance.GoldCount >= 10)
        {
            Manager.Instance.GoldCount -= 10;
            Manager.Instance.BulletPower += 1;
            Manager.Instance.Fps += 0.05f;
            Manager.Instance.VerticalSpeed += 0.01f;
            Manager.Instance.PlayerLevel += 1;            
        }
        else
        {
            Debug.Log("No Gold!!");
        }
    }

    public void SelectCharacter(int _characterNumber)
    {
        ButtonClick.characterNumber = _characterNumber;
        if (_characterNumber == 1)
        {
            SelectButton_1();
        }
        else if (_characterNumber == 2)
        {
            SelectButton_2();
        }
        else if (_characterNumber == 3)
        {
            SelectButton_3();
        }
    }

    public void SelectButton_1()
    {
        SceneManager.LoadScene("Scene/Play_green");
    }

    public void SelectButton_2()
    {
        SceneManager.LoadScene("Scene/Play_yellow");
    }

    public void SelectButton_3()
    {
        SceneManager.LoadScene("Scene/Play_blue");
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Scene/SelectUI");
    }

    public void UpgradePopUp()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (!Manager.Instance.IsPause)
            {
                UpgradePop.SetActive(false);
            }
            else
            {
                UpgradePop.SetActive(true);
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (!Manager.Instance.IsPause)
            {
                UpgradePop.SetActive(false);
            }
            else
            {
                UpgradePop.SetActive(true);
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            if (!Manager.Instance.IsPause)
            {
                UpgradePop.SetActive(false);
            }
            else
            {
                UpgradePop.SetActive(true);
            }
        }
    }

    public void Update()
    {
        UpgradePopUp();
    }
}
