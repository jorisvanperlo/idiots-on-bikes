using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRot : MonoBehaviour
{
    public float rotSpeed;
    public Vector3 rot;

    // Update is called once per frame
    void Update()
    {
        rot.x = rotSpeed;
        transform.Rotate( rot * Time.deltaTime);
    }
}
