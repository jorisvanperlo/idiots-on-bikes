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
    public GameObject finish;

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
    public float maxBoost;

  

    public bool finished;
    public bool raceStart;
    public float timer;


    private void FixedUpdate()
    {
        rb.AddForce(transform.forward * accForce * boostForce * Time.deltaTime);
    }


    void Update()
    {
         timer += 1.0f * Time.deltaTime;

        rot.y = Input.GetAxis("Horizontal");
        transform.Rotate(rot * sence * Time.deltaTime);


        if (isBoosting == false)
        {
            if (boost <= maxBoost)
            {
                boost += boostRefillSpeed * Time.deltaTime;
            }
        }
        if (boost > requireBoost)
        {
            canBoost = true;
        }

        if (boost > 0 && canBoost == true)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
               boostForce = boostForceWhenActive;
               isBoosting = true;
                cam.transform.GetComponent<CamFOV>().IncreaseFov();
            }
            if (Input.GetKeyUp(KeyCode.W))
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
