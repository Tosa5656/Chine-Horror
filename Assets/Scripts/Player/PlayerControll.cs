using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [SerializeField] float WalkSpeed = 150f;
    [SerializeField] float Runspeed = 200f;
    public Rigidbody rb;

    void FixedUpdate()
    {
        Walk();
    }

    private void Walk()
    {
        Vector3 velocity = new Vector3();

        if(Input.GetKey(KeyCode.W))
        {
            velocity += transform.forward * WalkSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.S))
        {
            velocity -= transform.forward * WalkSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.A))
        {
            velocity -= transform.right * WalkSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.D))
        {
            velocity += transform.right * WalkSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            velocity *= Runspeed;
        } 
		else 
        {
            velocity *= WalkSpeed;
        }

        velocity.y = rb.velocity.y;
        
        rb.velocity = velocity;

    }
}
