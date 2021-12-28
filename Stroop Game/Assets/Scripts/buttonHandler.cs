using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// This class was for testing implementation methods for the button input and updating the variables on the game screen (OUTDATED),
// commented out to prevent confusion relating to other c# scripts.
public class buttonHandler : MonoBehaviour
{
    /*
    private Button currentButton;
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI score;
    private int currentScore;
    private int roundNum;

    // custom color object for pink since it does not exist in current selection of unity object colors
    private static Color Pink = new Color(255, 0, 228);
    private string[] words = new string[4] {"Red", "Blue", "Yellow", "Pink"};
    private Color[] colours = new Color[4] {Color.red, Color.blue, Color.yellow, Pink};


    // Start is called before the first frame update
    void Start()
    {
        currentButton = gameObject.GetComponent<Button>();
        currentButton.onClick.AddListener(OnClick);

        titleText.GetComponent<TextMeshPro>();
        titleText.text = words[Random.Range(0,4)];
        titleText.color = colours[Random.Range(0,4)];

        //currentScore = 0;
        //score.SetText("Score: 0");

        roundNum = 1;
    }

    // Update is called once per frame
    void Update()
    {
        score.SetText("Score: " + currentScore);
    }


    void OnClick(){
        currentScore = currentScore + 1;
        Debug.Log("CLICKED");
    }

    // main gameplay loop, determines the correct colors of the buttons and text, does actions accordingly.
    public void updateColour(){ 
        //titleText.color = Color.red;
        //Debug.Log("CLICKED");

        // could not use a switch statement here due to values needing to be constant, therefore using colors as a variable would not work
        // to check conditions
        if (gameObject.name == "redButton" && titleText.color == Color.red){ 
            Debug.Log("CORRECT RED");
            currentScore =+ 1;
        }
        if (gameObject.name == "blueButton" && titleText.color == Color.blue){
            Debug.Log("CORRECT BLUE");
            currentScore =+ 2;
        }
        if (gameObject.name == "yellowButton" && titleText.color == Color.yellow){
            Debug.Log("CORRECT YELLOW");
            currentScore =+ 3;
        }
        if (gameObject.name == "pinkButton" && titleText.color == Pink){
            Debug.Log("CORRECT PINK");
            currentScore =+ 4;
        }

        score.SetText("Score: " + currentScore);
        titleText.text = words[Random.Range(0,4)];
        titleText.color = colours[Random.Range(0,4)];
    }


    */

}
