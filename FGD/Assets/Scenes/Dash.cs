using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public Animator animator;   
    private Rigidbody2D rb;
    float nextDashTime = 0f;
    public float dashSpeed = 200f;
    public float startDashTime = 0f;
    private int playerDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        nextDashTime = startDashTime;
    }

    void Update()
    {
        if(playerDirection == 0){
            if(Input.GetKeyDown(KeyCode.A)){
                animator.SetBool("Dash", true);
                playerDirection = 1;
            }else if(Input.GetKeyDown(KeyCode.D))
            {
                animator.SetBool("Dash", true);
                playerDirection = 2;
            }else if (Input.GetKeyDown(KeyCode.W))
            {
                animator.SetBool("Dash up", true);
                playerDirection = 3;
            }else if (Input.GetKeyDown(KeyCode.S))
            {
                animator.SetBool("Dash down", true);
                playerDirection = 4;
            }
        }else{
            if(nextDashTime <= 0){
                playerDirection = 0;
                nextDashTime = startDashTime;
                rb.velocity = Vector2.zero;
            }else{
                nextDashTime -= Time.deltaTime;
                if(playerDirection == 1){
                    rb.velocity = Vector2.left * dashSpeed;
                }else if(playerDirection == 2){
                    rb.velocity = Vector2.right * dashSpeed;
                }else if(playerDirection == 3){
                    rb.velocity = Vector2.up * dashSpeed;
                }else if(playerDirection == 4){
                    rb.velocity = Vector2.down * dashSpeed;
                }
            }
        }
        DashStop();
    }
    public void DashStop()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("Dash", false);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("Dash", false);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("Dash up", false);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("Dash down", false);
        }
    }
}
