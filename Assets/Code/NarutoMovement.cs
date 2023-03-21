using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarutoMovement : MonoBehaviour{

public NUCharacterController2D controller;
public Animator animator;

public float runSpeed = 40f;

float horizontalMove = 0f;
bool jump = false;

    // Update is called once per frame
    void Update()
    {
       
     horizontalMove = Input.GetAxisRaw("Horizontals") * runSpeed;

     animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

     if (Input.GetButtonDown("Jumps"))
     {
        jump = true;
        animator.SetBool("IsJumping", true);
     }

    }

   public void OnLanding ()
{
    animator.SetBool("IsJumping", false);
}

void FixedUpdate ()
{
    //move our character
    controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
    jump = false;
}

}
