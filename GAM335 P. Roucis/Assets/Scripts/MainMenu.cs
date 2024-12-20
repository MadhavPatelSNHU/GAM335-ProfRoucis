using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource GameManager;
    public AudioClip Pressed;
    public void PlayButton()
    {
        GameManager.clip = Pressed;
        GameManager.Play();
        SceneManager.LoadScene("Tutoria&Story");
    }

    public void HowToButton()
    {
        GameManager.clip = Pressed;
        GameManager.Play();
        SceneManager.LoadScene("HowTo");
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void HardButton()
    {
        GameManager.clip = Pressed;
        GameManager.Play();
        SceneManager.LoadScene("Hard Hub");
    }
}
