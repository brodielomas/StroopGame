using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// This class handles the scores that are displayed on the end screen for the player to see how well they did.
public class scoreHandler : MonoBehaviour
{

    public TextMeshProUGUI scoreText;   
    public TextMeshProUGUI timerText; 
    public TextMeshProUGUI highScoreText;     

    int score;
    float time;
    float highScore;

    // Start is called before the first frame update
    void Start()
    {
        // gets the total score, total time and the highest score from the game scene and displays these values on the end/restart screen,
        // also shows the time at 2 decimal places.
        score = PlayerPrefs.GetInt("Score");
        scoreText.text = ("Score: " + score);

        time = PlayerPrefs.GetFloat("Timer");
        timerText.text = ("Time: " + time.ToString("F2"));

        highScore = PlayerPrefs.GetInt("HighScore");
        highScoreText.text = ("HIGHEST SCORE: " + highScore);
    }
}
