using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public bool P1Finish;
    public bool P2Finish;

    public GameObject P1;
    //public GameObject P2;

    public float P1EndTime;
    public float P2EndTime;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (P1Finish == true && P2Finish == true)
        {
            RaceOver();
        }
    }
    public void P1Finished()
    {
        P1Finish = true;
    }
    public void P2Finished()
    {
        P2Finish = true;
    }
    public void RaceOver()
    {
        P1EndTime = P1.GetComponent<Movement>().timer;
        //P2EndTime = P2.GetComponent<MovementP2>().timer;
    }
}
