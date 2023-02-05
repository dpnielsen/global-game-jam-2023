using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class init : MonoBehaviour
{
    public void Start()
    {
        PlayerPrefs.SetInt("eggs", 2);
        //PlayerPrefs.SetInt("max_eggs", 42);
        //Debug.Log("Setting eggs to 42");
        //FindObjectOfType<SoundManager>().Play("hey");
    }
}
