using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public Animator animator;
    public int Value;
    void OnTriggerEnter2D(Collider2D other) //check if a collider enters the trigger
    {
        if (other.gameObject.CompareTag("Player")) //check if the player entered the trigger        
        {
            animator.SetBool("Collected", true); //plays collected animation
            ScoreManager.instance.ChangeScore(Value); //increases score
            Destroy(gameObject); //removes item
        }
        
    }
}
