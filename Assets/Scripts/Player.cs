using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Player : MonoBehaviour
{

    public Animator animator;
    private CircleCollider2D cc;
    public float timeHitInterval;
    private bool canBeHit;

    void Start()
    {
        canBeHit = true;
        Debug.Log("yoyoyo");
        cc = gameObject.GetComponent<CircleCollider2D>();
        InvokeRepeating("canBeHitClear", 1, timeHitInterval);
    }

    void canBeHitClear()
    {
        canBeHit = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Tag: " + other.gameObject.tag);
        Debug.Log("Tag: " + other.gameObject.gameObject.tag);
        Debug.Log("Tag: " + other.tag);
        if (other.gameObject.tag == "obstacle")
        {
            if (canBeHit)
            {
                PlayerPrefs.SetInt("eggs", PlayerPrefs.GetInt("eggs") - 1);
                canBeHit = false;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        //Debug.Log("collision: " + collider.gameObject.name);
        Debug.Log("collision: " + collider.gameObject.name);
        animator.SetFloat("Speed", 0);
        
        if (collider.gameObject.tag == "egg")
        {
            PlayerPrefs.SetInt("eggs", PlayerPrefs.GetInt("eggs") + 1);
            Destroy(collider.gameObject);
            SoundManager.instance.Play("egg");
        }
        
        if (collider.gameObject.tag == "rotiegg")
        {
            PlayerPrefs.SetInt("eggs", PlayerPrefs.GetInt("eggs") + 1);
            Destroy(collider.gameObject);
            SoundManager.instance.Play("fart");
        }

        if (collider.gameObject.tag == "obstacle")
        {
            Debug.Log("fuglur");
        }
        
        //if (collider.gameObject.tag == "obstacle")
        //{
        //    PlayerPrefs.SetInt("eggs", PlayerPrefs.GetInt("eggs") + 1);
        //    Destroy(collider.gameObject);
        //    SoundManager.instance.Play("egg");
        //}

        if (collider.gameObject.tag == "end")
        {
            Debug.Log("--------------------------------");
            //if (PlayerPrefs.GetInt("fartpack") > 0)
            //{
            //    gameObject.GetComponent<PointEffector2D>().enabled = false;
            //    for (int i = 0; i < 1000; i++)
            //    {
            //        gameObject.transform.Translate(0, 0.1f, 0);
            //    }
            //}
            //SceneManager.LoadScene("shop", LoadSceneMode.Single);
        }
    }
}
