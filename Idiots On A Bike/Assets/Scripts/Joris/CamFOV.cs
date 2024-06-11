using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFOV : MonoBehaviour
{
    public Camera cam;
    public bool isFovChange;
    public float changeProgress;
    public float changeTime;
    public float oldFov;
    public float newFov;
    public float zoomInFov;
    public float zoomOutFov;
    public void IncreaseFov()
    {
        newFov = zoomOutFov;
        changeProgress = 0.0f;
        isFovChange = true;
    }
    public void DecreaseFov()
    {
        newFov = zoomInFov;
        changeProgress = 0.0f;
        isFovChange = true;
    }

    void Update()
    {
        if (isFovChange == true)
        {
            changeProgress += Time.deltaTime / changeTime;
            oldFov = cam.fieldOfView;
            cam.fieldOfView = Mathf.Lerp(oldFov,newFov,changeProgress);

            if (changeProgress >= 1.0f)
            {
                isFovChange = false;
                cam.fieldOfView = newFov;
            }
        }
        
    }
}
