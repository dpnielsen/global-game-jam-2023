using System.Collections;
using System.Collections.Generic;
//using UnityEditor.UI;
using UnityEngine;

public class ObjectMovementPoints : MonoBehaviour
{

    public Transform startPoint;
    public Transform endPoint;

    public float speed;
    public float amplitude;
    public float amplitudeOffset;

    public float Yspeed;
    public float Yamplitude;
    public float YamplitudeOffset;



    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPoint.position;

    }

    // Update is called once per frame
    void Update()
    {
        var Yoffset = new Vector3(0, Mathf.Sin(Time.time * Yspeed) * Yamplitude + Yamplitude, 0);
        var position = Vector3.Lerp(startPoint.position + Yoffset, endPoint.position + Yoffset, Mathf.Sin(Time.time * speed)
            * amplitude + amplitudeOffset);

        position.z = transform.position.z;

        Vector3 ls = transform.localScale;
        
        //if (transform.position.x <= 0.5f)
        //{
        //    ls.x *= -1;
        //    transform.localScale = ls;
        //}
        
        transform.position = position;

    }
}
