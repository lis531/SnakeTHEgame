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
        Button btn = rozpoczecie.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
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
            transform.Translate(transform.up * currentspeed/100);
        }
    }
    public void skrecanie_prawo()
    {
        transform.Rotate(Vector3.forward * 90);
    }
    public void skrecanie_lewo()
    {
        transform.Rotate(Vector3.forward * -90);
    }
    public void skrecanie_gora()
    {
        transform.Rotate(Vector3.forward * 90);
    }
    public void skrecanie_dol()
    {
        transform.Rotate(Vector3.forward * 90);
    }
}
