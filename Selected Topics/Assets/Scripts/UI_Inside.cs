using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Inside : MonoBehaviour
{
    public GameObject StartMenu, Options,Player;


    // Start is called before the first frame update
    void Start()
    {
        StartMenu.SetActive(false);
        Options.SetActive(false);
    }


    public void Menu()
    {
        StartMenu.SetActive(true);
        Options.SetActive(false);

        Player.SetActive(false);
    }

    public void Continue()
    {
        StartMenu.SetActive(false);
        Player.SetActive(true);

    }

    public void OptionsMenu()
    {
        StartMenu.SetActive(false);
        Options.SetActive(true);

    }

    public void Back()
    {
        StartMenu.SetActive(true);
        Options.SetActive(false);
    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }

}
