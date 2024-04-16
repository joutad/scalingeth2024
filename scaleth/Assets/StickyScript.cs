using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", Mathf.Abs(myRigidBody.velocity.x));
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidBody.velocity = Vector2.up * 10;
            animator.SetBool("IsJumping", true);
        }
        animator.SetBool("IsJumping", false);
        if (Input.GetKeyDown(KeyCode.A))
        {
            myRigidBody.velocity = Vector2.left * 5;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            myRigidBody.velocity = Vector2.right * 5;
        }
    }
}
