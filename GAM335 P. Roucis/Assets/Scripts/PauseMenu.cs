using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused;

    void Start()
    {

        pauseMenu.SetActive(false); //starts the scene without it being paused
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused) //if not paused
            {
                isPaused = true;
                PauseGame(); //pause the game
            }
            else
            {
                isPaused = false;
                ResumeGame(); //if is paused resume the game
            }

        }
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true); //brings up UI and stops everything
        Time.timeScale = 0;

    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false); //brings UI away and starts everything again
        Time.timeScale = 1;

    }


}
