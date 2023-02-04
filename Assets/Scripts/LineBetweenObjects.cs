using System;
using UnityEngine;

public class LineBetweenObjects : MonoBehaviour
{
    public Transform startTransform;
    public Transform endTransform;
    private LineRenderer lineRenderer;
    private bool Equipped = false;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.Return))
        {
            Equipped = true;
        }

        if (Equipped)
        {
            lineRenderer.SetPosition(0, startTransform.position);
            lineRenderer.SetPosition(1, endTransform.position);     
        }
        
    }
}