using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public GameObject bike;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            bike.GetComponent<Animator>().Play("Steer Left");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            bike.GetComponent<Animator>().Play("Steer Left Reverse");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            bike.GetComponent<Animator>().Play("Steer Right");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            bike.GetComponent<Animator>().Play("Steer Right Reverse");
        }
    }
}
