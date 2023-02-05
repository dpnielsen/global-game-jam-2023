using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class deathscript : MonoBehaviour
{
    public TMPro.TextMeshProUGUI eggsCount;

    public Button reset;
    public void Start()
    {
        reset.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("intro", LoadSceneMode.Single);
        });
        eggsCount.text = "Score: " + PlayerPrefs.GetInt("score", 0);
        
    }
}
