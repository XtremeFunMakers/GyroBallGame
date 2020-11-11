using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MAINMENU : MonoBehaviour
{
    private void Awake()
    {
        
    }
    public void level_1()
    {
        FindObjectOfType<AudioManager>().PlaySound("Click");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quitgame()
    {
        FindObjectOfType<AudioManager>().PlaySound("Click");
        Debug.Log("quit");
        Application.Quit();
        
    }
    public void level_2()
    {
        SceneManager.LoadScene(2);
    }
    public void level_3()
    {
        SceneManager.LoadScene(3);
    }
    public void level_4()
    {
        SceneManager.LoadScene(4);
    }
    public void level_5()
    {
        SceneManager.LoadScene(5);
    }
    public void level_6()
    {
        SceneManager.LoadScene(6);
    }
    public void level_7()
    {
        SceneManager.LoadScene(7);
    }
    public void level_8()
    {
        SceneManager.LoadScene(8);
    }
    public void level_9()
    {
        SceneManager.LoadScene(9);
    }
    public void level_10()
    {
        SceneManager.LoadScene(10);
    }
}
