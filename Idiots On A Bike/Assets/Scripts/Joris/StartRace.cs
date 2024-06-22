using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRace : MonoBehaviour
{
    public float timer;
    public Behaviour fiets;
    public Behaviour fiets2;
    public Behaviour start;

    public Behaviour P1FWheel;
    public Behaviour P1BWheel;

    public Behaviour P2FWheel;
    public Behaviour P2BWheel;

    void Update()
    {
        timer += 1.0f * Time.deltaTime;

        if (timer >= 5)
        {
          fiets.enabled = true;
          fiets2.enabled = true;
          P1FWheel.enabled = true;
          P1BWheel.enabled = true;
          P2FWheel.enabled = true;
          P2BWheel.enabled = true;

          start.enabled = false;
        }
    }
}
