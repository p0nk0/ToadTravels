using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeQuit : MonoBehaviour
{
 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) == true) //if the user presses escape
        {
            Debug.Log("worked");
            Application.Quit(); //closes the game
        }
    }
}
