using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void playGame_Game()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //load next scene
        SceneManager.LoadScene("Game"); // 1000 word
    }

    public void playGame_Game1()
    {
        SceneManager.LoadScene("Game 1"); // Disney characters
    }
    public void playGame_Game2()
    {
        SceneManager.LoadScene("Game 2"); // sports
    }
    public void playGame_Game3()
    {
        SceneManager.LoadScene("Game 3"); // countries
    }

    public void QuitGame()
    {
        Debug.Log("QUIT"); 
        Application.Quit(); //because this wont work in unity  (will close the program whenever i build it). 
    }
}
