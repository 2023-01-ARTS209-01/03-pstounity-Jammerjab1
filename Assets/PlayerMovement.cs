using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 100f;

    float horizontalValue = 0f;
    bool jump = false;

    // Update is called once per frame
    void Update ()
    {
        horizontalValue = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        animator.SetFloat("Speed", Mathf.Abs(horizontalValue));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate ()
    {
        controller.Move(horizontalValue * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
