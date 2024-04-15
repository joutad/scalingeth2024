using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyScript2 : MonoBehaviour
{
    public Rigidbody2D otherRigidBody;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            otherRigidBody.velocity = Vector2.up * 10;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            otherRigidBody.velocity = Vector2.left * 5;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            otherRigidBody.velocity = Vector2.right * 5;
        }
    }
}
