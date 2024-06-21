using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBody2 : MonoBehaviour
{
    public GameObject bike;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            bike.GetComponent<Animator>().Play("Steer Left Body");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            bike.GetComponent<Animator>().Play("Steer Left Body Reverse");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            bike.GetComponent<Animator>().Play("Steer Right Body");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            bike.GetComponent<Animator>().Play("Steer Right Body Reverse");
        }
    }
}
