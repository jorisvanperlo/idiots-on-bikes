using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRace : MonoBehaviour
{
    public float timer;
    public Behaviour fiets;
    public Behaviour cam;
    public Behaviour camHolder;
    public Behaviour start;

    void Update()
    {
        timer += 1.0f * Time.deltaTime;

        if (timer >= 5)
        {
          fiets.enabled = true;
          cam.enabled = true;
          camHolder.enabled = true;
          start.enabled = false;
        }
    }
}
