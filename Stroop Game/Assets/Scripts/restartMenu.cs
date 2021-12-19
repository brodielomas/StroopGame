using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This class handles all of the interactions of the buttons within the end/restart screen and does the approprate actions associated.
public class restartMenu : MonoBehaviour
{
    // Loads the game scene again if they player wants to try again.
    public void Restart(){
        SceneManager.LoadScene("GameScene");
    }

    // Redirects the player back to the Main Menu.
    public void MainMenu(){
        SceneManager.LoadScene("StartMenu");
    }

    // Quits the application.
    public void Quit(){
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
