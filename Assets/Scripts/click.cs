using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class click : MonoBehaviour
{
    public string sceneName;

    public void OnMouseUp()
    {
        AudioListener al = FindObjectOfType<AudioListener>();
        Destroy(al);
        Debug.Log("yoyo");
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void OnMouseDown()
    {
        Debug.Log("yoyo22: " + PlayerPrefs.GetInt("eggs"));
		
    }
}
