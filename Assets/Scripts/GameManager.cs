using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameEnded = false;
    
    public void EndGame() //function to end game
    {
        if (GameEnded == false)
        {
            GameEnded = true;
            Invoke("Restart", 1F); //waits before restarting in order to play death animation
        }
    }

    void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //reloads the current scene
    }

}
