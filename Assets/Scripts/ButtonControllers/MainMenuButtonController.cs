﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuButtonController : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void About()
    {
        SceneManager.LoadScene("About");
    }
    public void QuitGame()
    {
        Debug.Log("Application quit");
        Application.Quit();
    }
}