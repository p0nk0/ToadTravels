using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public Animator animator;
    public string GotoLevel;
    void OnTriggerEnter2D(Collider2D other)
    {
        animator.SetBool("CheckpointPass", true);
        Invoke("LoadLevel", 2f);
    }
    void LoadLevel()
    {
        SceneManager.LoadScene(GotoLevel);
    }
}
