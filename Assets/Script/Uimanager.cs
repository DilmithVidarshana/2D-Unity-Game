using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Uimanager : MonoBehaviour
{
    
    public void Quickgame()
    {
        Application.Quit();
    }

    public void Play()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void Restart()
    {
         Time.timeScale = 1;
        SceneManager.LoadScene(1);
        print("Restart");
    }
    public void QuickMainmenu()
    {
      
        SceneManager.LoadScene(0);
    }
}
