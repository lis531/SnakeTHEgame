using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    GameObject poczatek;
    GameObject snake;
    private void Start()
    {
        Snake.transform.position = (-0.396f, 0f, 0f);
    }

    void Update()
    {
        //snejkMufs = GameObject.Find("Snake").transform.position;
        poczatek = GameObject.Find("Start");
        //if (Input.GetButtonDown());
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
        }




    }
}
