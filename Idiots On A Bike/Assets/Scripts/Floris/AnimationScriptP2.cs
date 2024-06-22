using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScriptP2 : MonoBehaviour
{
    public GameObject bike;
    public bool leftPos;
    public bool rightPos;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            bike.GetComponent<Animator>().Play("Steer Left");
            leftPos = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            if (rightPos == false)
            {
                bike.GetComponent<Animator>().Play("Steer Left Reverse");
            }
            leftPos = false;
        }


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            bike.GetComponent<Animator>().Play("Steer Right");
            rightPos = true;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (leftPos == false)
            {
                bike.GetComponent<Animator>().Play("Steer Right Reverse");
            }
            rightPos = false;
        }
    }
}
