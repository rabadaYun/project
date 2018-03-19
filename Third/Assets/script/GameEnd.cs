using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour {

    public void GameEnding()
    {
        if (Manager.Instance.GPlay == false)
        {
            Manager.Instance.GameOver();
        }
    }
}
