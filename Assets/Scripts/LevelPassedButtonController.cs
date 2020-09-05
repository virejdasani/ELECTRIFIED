using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelPassedButtonController : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene("Level2");
    }
    public void QuitGame()
    {
        Debug.Log("Application quit");
        Application.Quit();
    }
    public void Menu()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}