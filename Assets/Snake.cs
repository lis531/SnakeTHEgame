using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Snake : MonoBehaviour
{
    public Button rozpoczecie;
    private Rigidbody2D rb;
    float currentspeed = 100f;
    bool kobra = true;
    GameObject poczatek;
    private GameObject snake;
    private void Start()
    {
        Button btn = rozpoczecie.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        rb = transform.GetComponent<Rigidbody2D>();
        gameObject.GetComponent<Button>().onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        bool kobra = false;
        if (kobra == true)
        {
            float movementHorizontal = Input.GetAxis("Horizontal");
            Vector3 movement = new Vector3(movementHorizontal, 0f, 0f);
            rb.AddForce(movement * currentspeed);
        }
        
    }    
    void OnButtonClick()
    {
        //bool kobra = false;
    }
}
