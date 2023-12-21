using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public Animator animator;
    public PlayerMovement movement;
    void OnTriggerEnter2D(Collider2D other) //if a colider enters the trigger
    {
        if (other.gameObject.CompareTag("Player")) //if the player entered the trigger
        {
            animator.SetBool("IsDead", true); //plays death animation
            LivesManager.instance.ChangeLives(1); //removes a life
            FindObjectOfType<GameManager>().EndGame(); //ends the game
            movement.enabled = false; //disables movement
        }

    }
}
