using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public static int characterNumber = 1;
    public GameObject UpgradePop;

    public void UpgradeButton()
    {
        if (Manager.Instance.IsPause)
        {
            Time.timeScale = 1;
            Manager.Instance.IsPause = false;
            Debug.Log("Restart");

        }
        else
        {
            Time.timeScale = 0;
            Manager.Instance.IsPause = true;
            Debug.Log("Pause");
        }
      //  SceneManager.LoadScene("Scene/Upgrade");
    }

    public void UpgradeBullet()
    {
        Debug.Log("BulletUpgrade!");
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
