using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Snake : MonoBehaviour
{
    private Rigidbody2D rb;
    float currentspeed = 100f;
    bool kobra = true;
    GameObject poczatek;
    private GameObject snake;
    private void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        gameObject.GetComponent<Button>().onClick.AddListener(chodzenie);
    }

    void FixedUpdate()
    {
        
        //float movementHorizontal = Input.GetAxis("Horizontal");
        //float movementVertical = Input.GetAxis("Vertical");
        //poczatek = GameObject.Find("Start");
        //Vector3 movement = new Vector3(-movementHorizontal, 0f, -movementVertical);



    }
    private void chodzenie()
    {
        bool kobra = true;
        if (kobra == true)
        {
            float movementHorizontal = Input.GetAxis("Horizontal");
            Vector3 movement = new Vector3(movementHorizontal, 0f, 0f);
            rb.AddForce(movement * currentspeed);
        }
        
    }       
}
