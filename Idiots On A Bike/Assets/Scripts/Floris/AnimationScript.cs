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
            //bike.GetComponent<Animator>().Play("Steer Left Body");
            bike.GetComponent<Animator>().Play("Steer Left");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //bike.GetComponent<Animator>().Play("Steer Right Body");
            bike.GetComponent<Animator>().Play("Steer Right");
        }
    }
}
