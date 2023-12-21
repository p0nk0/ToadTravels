using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;
	public float runSpeed = 40f;

	float horizontalMove = 0f; //initialize movement variables
	float verticalMove = 0f;
	bool jump = false;
	
	//Update is called once per frame
	void Update () {

		//Updates speed based on player input
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		verticalMove = Input.GetAxisRaw("Vertical");

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove)); //updates variable to play run animation

		if (verticalMove > 0) 
		{
			jump = true;
			animator.SetBool("IsJumping", true); //plays jump animation
		}

	}

	public void OnLanding ()
    {
		animator.SetBool("IsJumping", false); //stops jump animation
    }

	void FixedUpdate ()
	{
		//Updates character position
		controller.Move(
            horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
	}
}
