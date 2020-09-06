using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseButtonController : MonoBehaviour
{
    public void levels()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void about()
    {
        SceneManager.LoadScene("About");
    }

}