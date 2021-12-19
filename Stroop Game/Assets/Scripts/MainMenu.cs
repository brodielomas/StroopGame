using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Class to manage the Main menu and the tasks that the buttons need to take.
public class MainMenu : MonoBehaviour
{

    // Loads and plays the game.
    public void Play(){
        SceneManager.LoadScene("GameScene");
    }

    // Quits the application.
    public void Quit(){
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
