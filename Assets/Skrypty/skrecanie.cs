using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class skrecanie : MonoBehaviour
{
    GameObject apbuton;
    GameObject dawnbuton;
    GameObject rigtbuton;
    GameObject leftbuton;
    private Vector2 _direction = Vector2.right;
    void Awake()
    {
        apbuton = GameObject.Find("Button up");
        dawnbuton = GameObject.Find("Button down");
        rigtbuton = GameObject.Find("Button right");
        leftbuton = GameObject.Find("Button left");
        apbuton.SetActive(false);
        dawnbuton.SetActive(false);


    }
    public void TaskOnClickLeft()
    {
        leftbuton.SetActive(false);
        rigtbuton.SetActive(false);
        apbuton.SetActive(true);
        dawnbuton.SetActive(true);
        _direction = Vector2.left;
    }
    public void TaskOnClickRight()
    {
        leftbuton.SetActive(false);
        rigtbuton.SetActive(false);
        apbuton.SetActive(true);
        dawnbuton.SetActive(true);
        _direction = Vector2.right;
    }
    public void TaskOnClickUp()
    {
        apbuton.SetActive(false);
        dawnbuton.SetActive(false);
        leftbuton.SetActive(true);
        rigtbuton.SetActive(true);
        _direction = Vector2.up;
    }
    public void TaskOnClickDown()
    {
        apbuton.SetActive(false);
        dawnbuton.SetActive(false);
        leftbuton.SetActive(true);
        rigtbuton.SetActive(true);
        _direction = Vector2.down;
    }
    //private void FixedUpdate()
    //{
       // this.transform.position = new Vector3(
           // Mathf.Round(this.transform.position.x) + _direction.x,
           // Mathf.Round(this.transform.position.y) + _direction.y,
          //  0.0f);
   // }
}
