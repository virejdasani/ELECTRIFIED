using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InGamePauseButtonController : MonoBehaviour
{
    public void PauseMenu()
    {
        SceneManager.LoadScene("PauseMenu");
    }
    
}