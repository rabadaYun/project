using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public static int characterNumber = 1;

    public void UpgradeButton()
    {
        SceneManager.LoadScene("Scene/SelectUI");
        Debug.Log("Upgrade!!");
      //  SceneManager.LoadScene("Scene/Upgrade");
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
}
