using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenu : MonoBehaviour
{
    public AudioSource GameManager;
    public AudioClip PressedBack;
    public void BackButton()
    {
        GameManager.clip = PressedBack;
        GameManager.Play();
        SceneManager.LoadScene("Main Menu");
    }
    public void BackButtonHard()
    {
        GameManager.clip = PressedBack;
        GameManager.Play();
        SceneManager.LoadScene("Hard Menu");
    }
}
