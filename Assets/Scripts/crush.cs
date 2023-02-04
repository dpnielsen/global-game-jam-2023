using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class crush : MonoBehaviour
{
    public GameObject man;
    public GameObject bird;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(man.transform.position);
            Debug.Log(bird.transform.position);
        }
    }
}
