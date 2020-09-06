using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathMenuController2 : MonoBehaviour
{
    public void TryAgain()
    {
        SceneManager.LoadScene("Level2");
    }
    public void QuitGame()
    {
        Debug.Log("Application quit");
        Application.Quit();
    }
    public void BackToLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}