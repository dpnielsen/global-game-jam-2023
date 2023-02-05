using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class click : MonoBehaviour
{
    public string sceneName;

    public void OnMouseUp()
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        AudioListener al = FindObjectOfType<AudioListener>();
        //AudioSource as = FindObjectOfType<AudioSource>();
        Destroy(al);
        Debug.Log("yoyo");
    }

    public void OnMouseDown()
    {
        Debug.Log("yoyo22: " + PlayerPrefs.GetInt("eggs"));
		
    }
}
