﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour {

    public void LoadTheGame()
    {
        SceneManager.LoadScene(1);

        Debug.Log("单科研是傻逼");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
