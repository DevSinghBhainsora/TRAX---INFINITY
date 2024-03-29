using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuMobile : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject UI;
    [SerializeField] GameObject SpeedUI;
    [SerializeField] GameObject CarAudio;
    public bool isPaused;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) )
        {
            if (isPaused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }

    public void pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        UI.SetActive(false);
        SpeedUI.SetActive(false);
        CarAudio.SetActive(false);
        isPaused = true;
    }

    public void resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        UI.SetActive(true);
        SpeedUI.SetActive(true);
        CarAudio.SetActive(true);
        isPaused = false;
        
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void levelSelect()
    {
        SceneManager.LoadScene("Level Selector");
        Time.timeScale = 1;
    }

    public void exit()
    {
        Application.Quit();
    }
}
