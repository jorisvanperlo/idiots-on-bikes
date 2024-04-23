using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject fiets;
    public Vector3 mov;
    public float hor;
    public float vert;
    public float speed;
    public float Acc;
    public float sence;


    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(mov * Time.deltaTime);
    }
}
