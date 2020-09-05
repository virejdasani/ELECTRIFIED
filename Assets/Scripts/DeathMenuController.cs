using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathMenuController : MonoBehaviour
{
    public void TryAgain()
    {
        SceneManager.LoadScene("Level1");
    }
    public void QuitGame()
    {
        Debug.Log("Application quit");
        Application.Quit();
    }
    public void BackToLevelSelect()
    {
        SceneManager.LoadScene("MainMenu");
    }
}