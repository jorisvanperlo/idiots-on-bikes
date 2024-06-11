using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 rot;
    public GameObject cam;
    public GameObject camHolder;
   
    public float accForce;
    public float sence;

    public float boost;
    public float boostRefillSpeed;
    public float boostForce;
    public float boostForceWhenActive;
    public float boostDrainSpeed;
    public bool isBoosting;
    public float requireBoost;
    public bool canBoost;

    public GameObject finish;

    public bool finished;
    public bool raceStart;
    public float timer;
    
    public float rayLength;
    public float airThick;
    public float groundThick;
    public float airBoost;
    public float airSpeedIncrease;
   

    private void FixedUpdate()
    {
        rb.AddForce(transform.forward * accForce * boostForce * airBoost * Time.deltaTime);
    }


    void Update()
    {
        if (finished == false)
        {
            timer += 1.0f * Time.deltaTime;
        }

        rot.y = Input.GetAxis("Horizontal");
        transform.Rotate(rot * sence * Time.deltaTime);


        if (isBoosting == false)
        {
            boost += boostRefillSpeed * Time.deltaTime;
        }
        if (boost > requireBoost)
        {
            canBoost = true;
        }

        if (boost > 0 && canBoost == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
               boostForce = boostForceWhenActive;
               isBoosting = true;
                cam.transform.GetComponent<CamFOV>().IncreaseFov();
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                boostForce = 1.0f;
                isBoosting = false;
                cam.transform.GetComponent<CamFOV>().DecreaseFov();
                if (boost < requireBoost)
                {
                    canBoost = false;    
                }
            }
        }
        else
        {
            boostForce = 1.0f;
            isBoosting = false;
            if (canBoost == true)
            {
                cam.transform.GetComponent<CamFOV>().DecreaseFov();
            }
            canBoost = false;
        }

        if (isBoosting == true) 
        {
            boost -= boostDrainSpeed * Time.deltaTime;
        }
        RaycastHit hit;
        if (Physics.Raycast(transform.position,-transform.up,out hit, rayLength))
        {
            rb.mass = groundThick;
            airBoost = 1.0f;
        }
        else
        {
            rb.mass = airThick;
            airBoost = airSpeedIncrease;
        }
    }

    private void OnTriggerEnter(Collider Hit)
    {
        if(Hit.gameObject.tag == ("LeftTurn"))
        {
            cam.transform.GetComponent<CameraMov>().LeftTurn();
            camHolder.transform.GetComponent<CamHolder>().LeftTurn();
        }
        if (Hit.gameObject.tag == ("RightTurn"))
        {
            cam.transform.GetComponent<CameraMov>().RightTurn();
            camHolder.transform.GetComponent<CamHolder>().RightTurn();
        }
        if (Hit.gameObject.tag == ("Finish"))
        {
            finish.transform.GetComponent<FinishLine>().P1Finished();
        }

    }
}
