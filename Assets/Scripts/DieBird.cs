using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Random = UnityEngine.Random;
using static UnityEngine.Random;

public class DieBird : MonoBehaviour
{
    private float x;
    private float y;
    private float z;

    void Start()
    {
        x = Random.Range(-1f, 1f);
        y = Random.Range(-1f, 1f);
        z = Random.Range(-1f, 1f);
    }
    private void FixedUpdate()
    {
        gameObject.transform.Translate(x, y, z);
    }
}
