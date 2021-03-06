﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    // public float forwardForce;
    // public float sidewaysForce;
    public float jumpSpeed;
    public int jumpCooldown;
    public int jumpCooldownMax;
    public CharacterController controller;
    public float jumpHeight = 3f;
    public float speed = 12f;
    public float gravity = -9.81f;
    Vector3 velocity;
    public Transform groundCheck;
    public float groundDistance = 0.3f;
    public LayerMask groundMask;
    public bool isGrounded = false;
    public bool blockdrop = false;
    public LayerMask blockMask;
    public Transform blockCheck;
    public bool isBlocked = false;








    void Update()
    {


        if(transform.position.y < -20)
        {
            Debug.Log("Game over");
        }

        if (transform.position.y < -20f)
        {
            FindObjectOfType<gameR>().EndGame();
        }



        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = 0f;
        }

        isBlocked = Physics.CheckSphere(blockCheck.position, groundDistance, groundMask);
        
        if (isBlocked == true)
        {
            FindObjectOfType<gameR>().EndGame();


        }





        if (jumpCooldown >= 1)
        {   jumpCooldown--;
        }



      //  if (Input.GetKey("d"))
 //       {
 //
 //           rb.AddForce(sidewaysForce, 0, 0);
 //       }
 //
 //       if (Input.GetKey("a"))
 //       {
 //
 //           rb.AddForce(-sidewaysForce, 0, 0);
 //
 //       }
 //       if (Input.GetKey("w"))
 //       {
 //           rb.AddForce(0, 0, forwardForce);
 //
 //
 //       }
 //       if (Input.GetKey("s"))
 //       {
 //           rb.AddForce(0, 0, -forwardForce);
 //
 //       }
                 //if (jumpCooldown == 0 && Input.GetKeyDown(KeyCode.Space))
                 //{
                 //   jumpCooldown = jumpCooldownMax;
 
                 //   GetComponent<Rigidbody>().velocity += jumpSpeed * Vector3.up;
                 //}


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

       controller.Move(move.normalized * speed * Time.deltaTime);

       if(Input.GetButtonDown("Jump") && isGrounded)
       {
            velocity.y = Mathf.Sqrt(jumpHeight * -2.0f * gravity);
       }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);







    }

    
}