﻿using UnityEngine;
using System.Collections;

public class CameraFOV : MonoBehaviour
{

    public float fov;
    public float focusRate;
    public float maxFOV = 150f;
    public float minFOV = 50f;
    public float zoomBoostKickinTime = 10;
    public string zoomOutButton = "w";
    public string zoomInButton = "e";

    private float zoomOutTime = 0;
    private float computedFocusRate;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        HandleZoom();

        GetComponent<Camera>().fieldOfView = fov;
    }

    void HandleZoom()
    {
        //computedFocusRate = GetComputedFocusRate();

        if (Input.GetKeyDown(zoomOutButton))
        {
            ZoomOut();
            //IncrementZoomOutTime();
        }
        else if (Input.GetKeyDown(zoomInButton))
        {
            ZoomIn();
        }
    }

    private float GetComputedFocusRate()
    {
        if (zoomOutTime < zoomBoostKickinTime)
        {
            return focusRate;

        }

        return focusRate * (fov * fov);
    }

    private void ZoomOut()
    {
        if (fov < maxFOV - focusRate)
        {
            fov += focusRate;
        }
        else
        {
            fov = maxFOV;
        }
    }

    private void ZoomIn()
    {
        if (fov > minFOV + focusRate)
        {
            fov -= focusRate;
        }
        else
        {
            fov = minFOV;
        }
    }

    private void IncrementZoomOutTime()
    {
        if (Input.GetKey(zoomOutButton))
        {
            zoomOutTime += Time.deltaTime; 
        }


    }
}