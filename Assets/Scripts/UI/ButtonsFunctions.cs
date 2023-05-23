using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsFunctions : MonoBehaviour
{
    private int LevelCount = 3;
    public void ReastartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void NextLevel()
    {
        //Debug.Log(SceneManager.GetActiveScene().buildIndex);
        if (SceneManager.GetActiveScene().buildIndex - 1 < LevelCount)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        else
            SceneManager.LoadScene(0);
    }
}
