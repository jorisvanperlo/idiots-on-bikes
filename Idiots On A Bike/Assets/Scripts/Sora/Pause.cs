using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject PMen;
    public GameObject PMenPa;
    public GameObject SPa;
    public GameObject MBGPa;
    public GameObject player;
    public GameObject timer;
    public GameObject highscoreTimer;
    public bool checkForMenu;
    public bool checkToLeave;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (checkToLeave == true)
            {
                if (checkForMenu == false)
                {
                    timer.SetActive(false);
                    highscoreTimer.SetActive(false);
                    Time.timeScale = 0;
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                    checkForMenu = true;
                    BackPause();
                }
                else
                {
                    timer.SetActive(true);
                    highscoreTimer.SetActive(true);
                    Time.timeScale = 1;
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                    checkForMenu = false;
                    Game();
                }
            }
        }
    }

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void BackPause()
    {
        PMenPa.SetActive(true);
        SPa.SetActive(false);
        MBGPa.SetActive(true);
    }

    public void CredPause()
    {
        PMenPa.SetActive(false);
        SPa.SetActive(true);
        MBGPa.SetActive(true);
    }

    public void Game()
    {
        PMenPa.SetActive(false);
        SPa.SetActive(false);
        MBGPa.SetActive(true);
    }
}
