using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject fiets;
    public Vector3 mov;
    public Vector3 rot;
    public float speed;
    public float Acc;
    public float sence;
    


    void Start()
    {
        
    }

    void Update()
    {
        rot.y = Input.GetAxis("Horizontal");
        mov.z = speed;

        
        transform.Translate(mov * Time.deltaTime);
        transform.Rotate(rot * sence * Time.deltaTime);

        
    }
}
