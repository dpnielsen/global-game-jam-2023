using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class RopeMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpForce = 10.0f;
    
    private bool Equipped = false;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.Return))
        {
            Equipped = true;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            
        }

        
        
    }

    private void FixedUpdate()
    {
        if (Equipped)
        {
            rb.velocity = new Vector2(-30f, rb.velocity.y);
        }
    }
}