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
    GameObject Snake;

    Snake snakeScript;

    void Awake()
    {
        snakeScript = gameObject.GetComponent<Snake>();

        Snake = gameObject;
        apbuton = GameObject.Find("Button up");
        dawnbuton = GameObject.Find("Button down");
        rigtbuton = GameObject.Find("Button right");
        leftbuton = GameObject.Find("Button left");

        apbuton.SetActive(false);
        dawnbuton.SetActive(false);
    }
    public void TaskOnClickLeft()
    {
        Snake.transform.rotation = Quaternion.Euler(0, 0, 90);
        leftbuton.SetActive(false);
        rigtbuton.SetActive(false);
        apbuton.SetActive(true);
        dawnbuton.SetActive(true);
    }
    public void TaskOnClickRight()
    {
        Snake.transform.rotation = Quaternion.Euler(0, 0, -90);
        leftbuton.SetActive(false);
        rigtbuton.SetActive(false);
        apbuton.SetActive(true);
        dawnbuton.SetActive(true);
    }
    public void TaskOnClickUp()
    {
        Snake.transform.rotation = Quaternion.Euler(0, 0, 0);
        apbuton.SetActive(false);
        dawnbuton.SetActive(false);
        leftbuton.SetActive(true);
        rigtbuton.SetActive(true);
    }
    public void TaskOnClickDown()
    {
        Snake.transform.rotation = Quaternion.Euler(0, 0, 180);
        apbuton.SetActive(false);
        dawnbuton.SetActive(false);
        leftbuton.SetActive(true);
        rigtbuton.SetActive(true);
    }
}
