using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    bool isPaused = false;

    private void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        if (isPaused)
        {

            //unpause
            Time.timeScale = 1.0f;

            //Hides the button when the game is unpaused.
            pauseUI.SetActive(false);

            //when isPaused is true, this line will set it to false
            isPaused = false;
        }
        else
        {
            //pause
            Time.timeScale = 0.0f;

            //shows button when the game is paused
            pauseUI.SetActive(true);

            //when isPaused is false, this line will set it to true.
            isPaused = true;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
