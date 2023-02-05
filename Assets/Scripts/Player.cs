using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Start()
    {
        Debug.Log("yoyoyo");
    }
    void OnCollisionEnter2D(Collision2D collider)
    {
        //Debug.Log("collision: " + collider.gameObject.name);
        if (collider.gameObject.tag == "obstacle")
        {
            PlayerPrefs.SetInt("eggs", PlayerPrefs.GetInt("eggs") + 1);
            Destroy(collider.gameObject);
            SoundManager.instance.Play("egg");
        }   
    }
}
