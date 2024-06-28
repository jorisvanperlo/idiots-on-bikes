using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRace : MonoBehaviour
{
    public float timer;
    public GameObject finish;
    public Behaviour fiets;
    public Behaviour fiets2;
    public Behaviour start;

    public Behaviour P1FWheel;
    public Behaviour P1BWheel;

    public Behaviour P2FWheel;
    public Behaviour P2BWheel;

    public GameObject fire1;
    public GameObject fire2;
    public GameObject fire3;
    public GameObject fire4;

    void Update()
    {
        timer += 1.0f * Time.deltaTime;

        if (timer >= 2)
        {
            fire1.SetActive(true);
            fire2.SetActive(true);
            fire3.SetActive(true);
            fire4.SetActive(true);
        }
        if (timer >= 5)
        {
          fiets.enabled = true;
          fiets2.enabled = true;
          P1FWheel.enabled = true;
          P1BWheel.enabled = true;
          P2FWheel.enabled = true;
          P2BWheel.enabled = true;

         
        }


        if (timer >= 30)
        {
            finish.SetActive(true);
            start.enabled = false;
        }
    }
}
