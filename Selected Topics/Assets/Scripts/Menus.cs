using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public GameObject StartMenu, OptionsMenu, AlgorithmsMenu, StartMenuInSide;
    void Start()
    {
        StartMenu.SetActive(true);
        OptionsMenu.SetActive(false);
        AlgorithmsMenu.SetActive(false);

    }

    #region Start Menu

    public void Play()
    {
        StartMenu.SetActive(false);
        OptionsMenu.SetActive(false);
        AlgorithmsMenu.SetActive(true);
    }

    public void Settings()
    {
        StartMenu.SetActive(false);
        AlgorithmsMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

    #endregion

    #region Settings

    public void Back()
    {
        OptionsMenu.SetActive(false);
        AlgorithmsMenu.SetActive(false);
        StartMenu.SetActive(true);
    }

    #endregion

    #region Algorithms Menu

    public void FollowPath()
    {
        SceneManager.LoadScene(2);
    }
    public void ObstacleAvoidance()
    {
        SceneManager.LoadScene(1);
    }
    public void SeekAlgo()
    {
        SceneManager.LoadScene(3);

    }
    public void FleeAlgo()
    {
        SceneManager.LoadScene(4);
    }
    #endregion

    /*
    #region Second Scene

    public void BackToMenu()
    {
        StartMenuInSide.SetActive(true);
    }

    public void Continue()
    {
        StartMenuInSide.SetActive(false);
    }

    public void QoitScene()
    {
        SceneManager.LoadScene(0);
    }
    #endregion
    */
}

