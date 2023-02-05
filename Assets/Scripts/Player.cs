using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Player : MonoBehaviour
{

    public Animator animator;

    void Start()
    {
        Debug.Log("yoyoyo");
    }
    void OnCollisionEnter2D(Collision2D collider)
    {
        Debug.Log("collision: " + collider.gameObject.name);
        animator.SetFloat("Speed", 0);
        if (collider.gameObject.tag == "obstacle")
        {
            PlayerPrefs.SetInt("eggs", PlayerPrefs.GetInt("eggs") + 1);
            Destroy(collider.gameObject);
        }   
    }
}
