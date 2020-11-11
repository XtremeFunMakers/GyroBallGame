using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject gameOverBG;
    public GameObject jumpButton;


    public static bool GameIsPaused = false;

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                resume();
            }
            else
            {
                paused();
            }
        }
    }

    public void paused()
    {
        FindObjectOfType<AudioManager>().PlaySound("Click");
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void resume()
    {
        FindObjectOfType<AudioManager>().PlaySound("Click");
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void restart()
    {
        FindObjectOfType<AudioManager>().PlaySound("Click");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void gameOver()
    {
        jumpButton.SetActive(false);
        
        gameOverBG.SetActive(true);
    }
    public void mainMenu()
    {
        FindObjectOfType<AudioManager>().PlaySound("Click");
        SceneManager.LoadScene(0);
    }
    public void nextLevel()
    {
        FindObjectOfType<AudioManager>().PlaySound("Click");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
