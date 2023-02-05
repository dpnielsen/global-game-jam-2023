using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Player : MonoBehaviour
{

    public Animator animator;
    private CircleCollider2D cc;

    void Start()
    {
        Debug.Log("yoyoyo");
        cc = gameObject.GetComponent<CircleCollider2D>();
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
            if (PlayerPrefs.GetInt("fartpack") > 0)
            {
                gameObject.GetComponent<PointEffector2D>().enabled = false;
                for (int i = 0; i < 1000; i++)
                {
                    gameObject.transform.Translate(0, 0.1f, 0);
                }
            }
            SceneManager.LoadScene("shop", LoadSceneMode.Single);
        }
    }
}
