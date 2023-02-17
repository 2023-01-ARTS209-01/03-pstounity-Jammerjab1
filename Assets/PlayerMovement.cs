using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 100f;

    float horizontalValue = 0f;

    // Update is called once per frame
    void Update ()
    {
        horizontalValue = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        animator.SetFloat("Speed", Mathf.Abs(horizontalValue));
    }

    void FixedUpdate ()
    {
        controller.Move(horizontalValue * Time.fixedDeltaTime, false, false);
    }
}
