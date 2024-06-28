using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject p1WinScreen;
    public GameObject p1LoseScreen;
    public GameObject p2WinScreen;
    public GameObject p2LoseScreen;

    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        p1WinScreen.SetActive(false);
        p2WinScreen.SetActive(false);
        p1LoseScreen.SetActive(false);
        p2LoseScreen.SetActive(false);

        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
