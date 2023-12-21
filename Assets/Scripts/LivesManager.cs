using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LivesManager : MonoBehaviour
{
    public static LivesManager instance;
    public TextMeshProUGUI text;
    public GameObject rootCanvas;
    public int Lives;

    //Start is called before the first frame
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            Lives = 10; //set lives
            text.text = ("Lives: " + Lives.ToString()); //initialize UI
        }
    }

    public void ChangeLives(int Value) //function to change lives
    {
        Lives -= Value;
        if (Lives <= 0) //if the player is out of lives
        {
            Lives = 10;
            SceneManager.LoadScene("StartMenu");
            text.text = ("Lives: " + Lives.ToString()); //return to start menu
            ScoreManager.instance.ResetScore();
            return;
        }
        else
        {
            ScoreManager.instance.ChangeScore(-5); //remove 5 points from the score 
            text.text = ("Lives: " + Lives.ToString()); //update UI
        }
        
    }


}
