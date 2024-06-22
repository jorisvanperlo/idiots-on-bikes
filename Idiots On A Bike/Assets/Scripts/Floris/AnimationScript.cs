using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public GameObject bike;
    public bool leftPos;
    public bool rightPos;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            bike.GetComponent<Animator>().Play("Steer Left");
            leftPos = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            if (rightPos == false)
            {
                bike.GetComponent<Animator>().Play("Steer Left Reverse");
            }
            leftPos = false;
        }


        if (Input.GetKeyDown(KeyCode.D))
        {
            bike.GetComponent<Animator>().Play("Steer Right");
            rightPos = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            if (leftPos == false)
            {
                bike.GetComponent<Animator>().Play("Steer Right Reverse");
            }
            rightPos = false;
        }
    }
}
