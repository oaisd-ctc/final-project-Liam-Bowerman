using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void GoToIntro()
    {
        SceneManager.LoadScene(4);
    }
    public void GoToSettings()
    {
        SceneManager.LoadScene(5);
    }
    public void GoToTitle()
    {
        SceneManager.LoadScene(0);
    }
    public void GoToCredits()
    {
        SceneManager.LoadScene(7);
    }
    public void ChangeVolume()
    {

    }
}
