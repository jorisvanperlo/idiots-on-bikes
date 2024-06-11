using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    public GameObject camHolder;
    
    public Quaternion startRot;
    public Quaternion newRot;
    public float rotProgress;
    public float rotTime;
    public bool isRotating;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = camHolder.transform.position;

        if (isRotating == true)
        {
            rotProgress += Time.deltaTime / rotTime;
            transform.rotation = Quaternion.Lerp(startRot, newRot, rotProgress);

            if (rotProgress >= 1f)
            {
                isRotating = false;
                transform.rotation = newRot;
            }
        }
    }
    public void LeftTurn()
    {
        if (isRotating == false)
        {
            isRotating = true;
            startRot = transform.rotation;
            newRot = Quaternion.Euler(0, -90, 0) * startRot;
            rotProgress = 0.0f;
        }
      
    }
    public void RightTurn()
    {
        if (isRotating == false)
        {
            isRotating = true;
            startRot = transform.rotation;
            newRot = Quaternion.Euler(0, 90, 0) * startRot;
            rotProgress = 0.0f;
        }
        
    }
}
