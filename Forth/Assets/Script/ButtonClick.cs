using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public void UpgradeButton()
    {
        Debug.Log("Upgrade!!");
      //  SceneManager.LoadScene("Scene/Upgrade");
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Scene/Play");
    }
}
