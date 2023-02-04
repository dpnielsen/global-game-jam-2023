using System;
using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class Global : MonoBehaviour
{
    public GameObject fjall;
    public GameObject mountain;
    public GameObject player;
    private PointEffector2D pe;
    void Start()
    {
        pe = fjall.GetComponent<PointEffector2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //pe.forceMagnitude = pe.forceMagnitude != 10 ? 10 : -20;
            pe.forceMagnitude = 15;
            //if (pe.forceMagnitude >= 15)
            //{
            //    pe.forceMagnitude = 15;
            //}
            //if (1 <= pe.forceMagnitude && pe.forceMagnitude < 15)
            //{
            //    pe.forceMagnitude *= 3;
            //}
            //
            //if (pe.forceMagnitude < 1)
            //{
            //    pe.forceMagnitude = 1;
            //}
            
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            pe.forceMagnitude = -25;
        }
    }

    private void FixedUpdate()
    {
        if (!fjall.GetComponent<BoxCollider2D>().IsTouching(player.GetComponent<BoxCollider2D>()))
        {
            mountain.transform.Translate(0, 0.01f, 0);
            //Debug.Log("touching");
        }
    }
}
