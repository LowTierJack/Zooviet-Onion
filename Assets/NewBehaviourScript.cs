using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public Gameobject pauseMenu;
    public bool isPaused;

    // Start is called before the first frame update 
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resumegame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timescale = 1f;
        isPaused = false;
    }
}