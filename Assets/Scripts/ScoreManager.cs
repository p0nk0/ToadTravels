using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    public GameObject rootCanvas;
    public int Score;

    // Start is called before the first frame
    void Start()
    {
        if (instance == null) //checks if no other canvas has been created
        {
            instance = this;
            Score = 0;
            DontDestroyOnLoad(rootCanvas); //prevents scene changes from destroying canvas
            text.text = ("Score: " + Score.ToString()); //initializes score
        }
        else if (instance != null) 
        {
            Destroy(rootCanvas); //destroys canvas if another one exists
        }
    }

    public void ChangeScore(int Value) //function to increase score
    {
        Score += Value;
        text.text = ("Score: " + Score.ToString()); //adds new score to UI
    }
    
    public void ResetScore(){ //function to reset score
        Score = 0;
        text.text = ("Score: " + Score.ToString()); //adds new score to UI//
    }
}
