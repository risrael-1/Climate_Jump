using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void RouteToAbout()
    {
        SceneManager.LoadScene("About");
    }

    public void RouteToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}


