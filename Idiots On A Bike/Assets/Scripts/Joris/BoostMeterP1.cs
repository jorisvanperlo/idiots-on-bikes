using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostMeterP1 : MonoBehaviour
{
    public GameObject p1;
    public Scrollbar scroll;

    void Update()
    {
        scroll.size = p1.GetComponent<Movement>().boost / 10;
    }
}
