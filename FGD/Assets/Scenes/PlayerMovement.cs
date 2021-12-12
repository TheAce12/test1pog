using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public CharacterController2D controller;
    public float runSpeed = 100f;
    public float dashSpeed = 200f;
    bool jump = false;
    bool crouch = false;
    float horizontalMove = 0;

    public void DashStop()
    {
        if(Input.GetKeyUp(KeyCode.A)){
            animator.SetBool("Dash", false);
        }else if(Input.GetKeyUp(KeyCode.D)){
            animator.SetBool("Dash", false);
        }else if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("Dash", false);
        }else if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("Dash", false);
        }
    }
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("Jump", true);
            
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }else if (Input.GetButtonUp("Crouch"))
        { 
            crouch = false;
        }

    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        
        jump = false;
        
    }
}