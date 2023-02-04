using System;
using UnityEngine;

public class RopeMovement : MonoBehaviour
{
    public Transform startTransform;
    public Transform endTransform;
    
    private bool Equipped = false;
    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.Return))
        {
            Equipped = true;
        }

        if (Equipped)
        {
             
        }
        
    }
}