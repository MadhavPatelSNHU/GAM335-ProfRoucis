using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Tutoria&Story");
    }

    public void HowToButton()
    {
        SceneManager.LoadScene("HowTo");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
