using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public bool P1Finish;
    public bool P2Finish;

    public GameObject P1;
    public GameObject P2;

    public float P1EndTime;
    public float P2EndTime;
    public bool raceOver;

    public Behaviour fiets;
    public Behaviour fiets2;

    public Behaviour P1FWheel;
    public Behaviour P1BWheel;

    public Behaviour P2FWheel;
    public Behaviour P2BWheel;

    public GameObject fire1;
    public GameObject fire2;
    public GameObject fire3;
    public GameObject fire4;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (P1Finish == true && P2Finish == true)
        {
            RaceOver();
            raceOver = true;

        }
    }
    public void P1Finished()
    {
        P1Finish = true;
        fiets.enabled = false;
        P1FWheel.enabled = false;
        P1BWheel.enabled = false;

        fire1.SetActive(true);
        fire2.SetActive(true);
    }
    public void P2Finished()
    {
        P2Finish = true;
        P2FWheel.enabled = false;
        P2BWheel.enabled = false;
        fiets2.enabled = false;

        fire3.SetActive(true);
        fire4.SetActive(true);
    }
    public void RaceOver()
    {
        P1EndTime = P1.GetComponent<Movement>().timer;
        P2EndTime = P2.GetComponent<MovementP2>().timer;
    }
}
