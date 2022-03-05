using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchPreview : MonoBehaviour
{
    private LineRenderer linerender;
    private Vector3 dragStartPoint;

    private void Awake ()
    {
        linerender = GetComponent<LineRenderer>();
    }
    
    public void SetStartPoint(Vector3 worldPoint)
    {
        dragStartPoint = worldPoint;
        linerender.SetPosition(0, dragStartPoint);
    }

    public void SetEndPoint(Vector3 worldPoint)
    {
        Vector3 pointOffset = worldPoint - dragStartPoint;
        Vector3 endPoint = transform.position + pointOffset;
        linerender.SetPosition(1, endPoint);
    }
}
