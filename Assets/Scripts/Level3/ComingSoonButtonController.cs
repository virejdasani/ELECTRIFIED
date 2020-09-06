using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ComingSoonButtonController : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void About()
    {
        SceneManager.LoadScene("About");
    }
}