using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CamHolder : MonoBehaviour
{
    public GameObject player;
    public bool isMoving;
    public Vector3 startPos;
    public float moveTime;
    public float moveProgress;
    public Vector3 bikePos;
    public Vector3 realOffSet;
    public Vector3 turnRot;
    public float rotSpeed;
    public Quaternion startRot;
    public Quaternion newRot;
    public float moveSpeed;

    void Start()
    {
        realOffSet = startPos;
    }


        void Update()
    {
        transform.position = player.transform.position;
        transform.Translate(realOffSet);

        if (isMoving == true)
        {
            moveProgress += Time.deltaTime / moveTime;
            transform.rotation = Quaternion.Lerp(startRot, newRot, moveProgress);
            realOffSet.x += moveSpeed * Time.deltaTime;

            if (moveProgress >= 1.0f)
            {
                isMoving = false;
                realOffSet = new Vector3 (0 , 3, -5);
                transform.rotation = newRot;
            }
        }
    }

    public void LeftTurn()
    {
        if (isMoving == false)
        {
            isMoving = true;
            moveProgress = 0.0f;
            startPos = realOffSet;
            startRot = transform.rotation;
            newRot = Quaternion.Euler(0, -90, 0) * startRot;
        }
    }
    public void RightTurn()
    {
        if (isMoving == false)
        {
            isMoving = true;
            moveProgress = 0.0f;
            startPos = realOffSet;
            startRot = transform.rotation;
            newRot = Quaternion.Euler(0, 90, 0) * startRot;
        }
    }
}
