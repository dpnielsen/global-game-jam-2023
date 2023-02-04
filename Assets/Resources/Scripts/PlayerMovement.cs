using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{

    public PlayerController controller;

    public float horizontalMove = 0f;
    //public float verticleMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;


    void Start()
    {
        
    }

    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        //verticleMove = Input.GetAxisRaw("Verticle") * runSpeed;
        Debug.Log("hello");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump occurred");
            jump = true;
    
        }


    }

    void FixedUpdate()
    {

        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        Debug.Log(jump);
        jump = false;

        
        
        
    }

}