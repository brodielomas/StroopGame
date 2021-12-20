using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

// Main class of game program, handles main gameplay loop, updating objects/variables and sending variables to other scenes for use.
public class titleHandler : MonoBehaviour
{

    public Button redButton;
    public Button blueButton;
    public Button yellowButton;
    public Button pinkButton;
    public TextMeshProUGUI score;
    public TextMeshProUGUI timeText;
    private int currentScore;
    private int wordNum;
    private int colorNum;
    private int roundNum;
    private float timer;
    private float finalTime;
    private float roundTimeSpent;
    private float roundScore;
    private int highestScore;
    private TextMeshProUGUI titleText;
    private static Color Pink = new Color(255, 0, 228);
    private string[] words = new string[4] {"Red", "Blue", "Yellow", "Pink"};
    private Color[] colours = new Color[4] {Color.red, Color.blue, Color.yellow, Pink};

    // Start is called before the first frame update
    void Start()
    {
        // Adds a click event to each color button.
        redButton.onClick.AddListener(() => ButtonMethod(redButton));
        blueButton.onClick.AddListener(() => ButtonMethod(blueButton));
        yellowButton.onClick.AddListener(() => ButtonMethod(yellowButton));
        pinkButton.onClick.AddListener(() => ButtonMethod(pinkButton));

        // Gets the text object that displays the color, sets the random numbers that will determine the colors text and visual component.
        titleText = gameObject.GetComponent<TextMeshProUGUI>();
        wordNum = Random.Range(0,4);
        colorNum = Random.Range(0,4);

        // Checks that the text and visual aspect of the color being displayed is not the same, if it's the same it continuously resets
        // gets a new random number until they are different.
        while (wordNum == colorNum){
            wordNum = Random.Range(0,4);
            colorNum = Random.Range(0,4);
        }

        // Sets the color displayed to the string and color elements in their respective lists using the random numbers generated.
        titleText.text = words[wordNum];
        titleText.color = colours[colorNum];

        // The player is already loaded into the first round, so current round is 1. 
        // Also sets the max points that the player can get per round.
        roundNum = 1;
        roundScore = 50;

        // Keeps the highscore from previous games
        highestScore = PlayerPrefs.GetInt("HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        // Displays the time passed since the scene has loaded
        timer = timer + Time.deltaTime;
        timeText.text = ("Time: " + (timer));

        // Gets time passed, reset each round to determine score given to player.
        roundTimeSpent = roundTimeSpent + Time.deltaTime;

        // Gets the score for each round, the quicker a player is the higher score they get. 
        // Also checks for negative numbers (gives them 0) if they take too long.
        roundScore = roundScore - (roundTimeSpent / 100);
        if (roundScore <= 0){
            roundScore = 0;
        }
    }

    // Main gameplay loop, handles the score/time variables, the rounds for the game and checking/updating the displayed colors.
    private void ButtonMethod(Button currentButton){

        // 10 Rounds in the game
        if (roundNum < 10){
            // checks the color and updates the random numbers for the color variables.
            CheckColours(currentButton);
            wordNum = Random.Range(0,4);
            colorNum = Random.Range(0,4);

            // Checks that the text and visual aspect of the color being displayed is not the same, if it's the same it continuously resets
            // gets a new random number until they are different.
            while (wordNum == colorNum){
                wordNum = Random.Range(0,4);
                colorNum = Random.Range(0,4);
            }

            // Sets the color displayed to the string and color elements in their respective lists using the random numbers generated.
            titleText.text = words[wordNum];
            titleText.color = colours[colorNum];

            // Displays the updated score, updates the round number and resets the time and score that is used for scoring each round.
            score.SetText("Score: " + currentScore);
            roundNum = roundNum + 1;
            roundTimeSpent = 0;
            roundScore = 50;
        }
    
        // Once all rounds are finished, then goes to restart screen.
        else{
        
            // Checks the colors for the last round and updates score/time.
            CheckColours(currentButton);
            score.SetText("Score: " + currentScore);
            finalTime = timer;
            
            if (currentScore > highestScore){
                highestScore = currentScore;
            }

            // Sends the total score, time and highest score to be used by the end screen to be displayed to the player. 
            // Then loads end/restart screen.
            PlayerPrefs.SetInt("Score", currentScore);
            PlayerPrefs.SetFloat("Timer", finalTime);
            PlayerPrefs.SetInt("HighScore", highestScore);
            SceneManager.LoadScene("EndMenu");
        }
    }

    // This method, checks if the button pressed is the same visual color as the color being displayed to the player.
    private void CheckColours(Button currentButton){

            // These statements check if the buttons match the color being displayed, if so (if the player is correct) they update the score.
            // Tried using a switch statement here but had issues with a constant value being experceted rather than a Color value.  
            if (currentButton == redButton && titleText.color == Color.red){
                //currentScore = currentScore + 10;
                currentScore = currentScore + (int)roundScore;
            }
            else if (currentButton == blueButton && titleText.color == Color.blue){
                //currentScore = currentScore + 10;
                currentScore = currentScore + (int)roundScore;
            }
            else if (currentButton == yellowButton && titleText.color == Color.yellow){
                //currentScore = currentScore + 10;
                currentScore = currentScore + (int)roundScore;
            }
            else if (currentButton == pinkButton && titleText.color == Pink){
                //currentScore = currentScore + 10;
                currentScore = currentScore + (int)roundScore;
            }
    }
}
