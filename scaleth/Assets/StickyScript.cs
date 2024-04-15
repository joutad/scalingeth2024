using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidBody.velocity = Vector2.up * 10;
        }
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
