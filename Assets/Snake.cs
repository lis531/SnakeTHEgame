using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Snake : MonoBehaviour
{
    GameObject przycisk;
    public Button rozpoczecie;
    float currentspeed = 3f;
    bool kobra = false;
    GameObject poczatek;
    private GameObject snake;
    private void Start()
    {
        
        leftbuton.SetActive(true);
        rigtbuton.SetActive(true);
        Button btn = rozpoczecie.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        przycisk = GameObject.Find("Button left");
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
            transform.Translate(transform.forward * currentspeed/100);
        }
    }

}
