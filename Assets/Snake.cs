using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Snake : MonoBehaviour
{
    GameObject przycisk;
    public Button rozpoczecie;
    private Rigidbody2D rb;
    float currentspeed = 2f;
    bool kobra = false;
    GameObject poczatek;
    private GameObject snake;
    private void Start()
    {
        Button btn = rozpoczecie.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        rb = transform.GetComponent<Rigidbody2D>();
        przycisk = GameObject.Find("Button");
    }

    private void TaskOnClick()
    {
        kobra = true;
        Destroy(przycisk);
    }    

    void FixedUpdate()
    {
        if (kobra == true)
        {
            Vector3 movement = new Vector3(1f, 0f, 0f);
            rb.AddForce(transform.up * currentspeed);
        }
    }
    void skrecanie()
    {

    }




}
