using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostMeterP2 : MonoBehaviour
{
    public GameObject p2;
    public Scrollbar scroll;
    
    void Update()
    {
        scroll.size = p2.GetComponent<MovementP2>().boost / 10;
    }
}
