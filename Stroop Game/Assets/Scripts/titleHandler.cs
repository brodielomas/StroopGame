using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class titleHandler : MonoBehaviour
{

    public Button redButton;
    public Button blueButton;
    public Button yellowButton;
    public Button pinkButton;
    public TextMeshProUGUI score;
    private int currentScore;
    private int wordNum;
    private int colorNum;
    private int roundNum;
    private TextMeshProUGUI titleText;
    private static Color Pink = new Color(255, 0, 228);
    private string[] words = new string[4] {"Red", "Blue", "Yellow", "Pink"};
    private Color[] colours = new Color[4] {Color.red, Color.blue, Color.yellow, Pink};

    // Start is called before the first frame update
    void Start()
    {
        // adds a click event to each color button
        redButton.onClick.AddListener(() => buttonMethod(redButton));
        blueButton.onClick.AddListener(() => buttonMethod(blueButton));
        yellowButton.onClick.AddListener(() => buttonMethod(yellowButton));
        pinkButton.onClick.AddListener(() => buttonMethod(pinkButton));

        // 
        titleText = gameObject.GetComponent<TextMeshProUGUI>();
        wordNum = Random.Range(0,4);
        colorNum = Random.Range(0,4);

        while (wordNum == colorNum){
            Debug.Log("IN WHILE");
            wordNum = Random.Range(0,4);
            colorNum = Random.Range(0,4);
        }

        titleText.text = words[wordNum];
        titleText.color = colours[colorNum];

        roundNum = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void buttonMethod(Button currentButton){
        if (roundNum <= 10){
            if (currentButton == redButton && titleText.color == Color.red){
                Debug.Log("RED CLICKED");
                currentScore = currentScore + 1;
            }
            else if (currentButton == blueButton && titleText.color == Color.blue){
                Debug.Log("BLUE CLICKED");
                currentScore = currentScore + 1;
            }
            else if (currentButton == yellowButton && titleText.color == Color.yellow){
                Debug.Log("YELLOW CLICKED");
                currentScore = currentScore + 1;
            }
            else if (currentButton == pinkButton && titleText.color == Pink){
                Debug.Log("PINK CLICKED");
                currentScore = currentScore + 1;
            }

            wordNum = Random.Range(0,4);
            colorNum = Random.Range(0,4);

            while (wordNum == colorNum){
                Debug.Log("IN WHILE");
                wordNum = Random.Range(0,4);
                colorNum = Random.Range(0,4);
            }

            titleText.text = words[wordNum];
            titleText.color = colours[colorNum];

            score.SetText("Score: " + currentScore);
            roundNum = roundNum + 1;
        }
    
    else{
        // switch to restart screen
        titleText.text = "END";
    }
    }
}
