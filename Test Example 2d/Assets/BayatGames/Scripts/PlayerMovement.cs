using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float speed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        if(Input.GetButton("Jump"))
        {
            animator.SetBool("IsJump", true);
            jump = true;
           
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJump", false);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
