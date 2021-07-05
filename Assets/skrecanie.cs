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
    void Awake()
    {
        apbuton = GameObject.Find("Button up");
        dawnbuton = GameObject.Find("Button down");
        rigtbuton = GameObject.Find("Button right");
        leftbuton = GameObject.Find("Button left");
        apbuton.SetActive(false);
        dawnbuton.SetActive(false);
        leftbuton.SetActive(false);
        rigtbuton.SetActive(false);

    }
    public void TaskOnClickLeft()
    {
        leftbuton.SetActive(false);
        rigtbuton.SetActive(false);
        apbuton.SetActive(true);
        dawnbuton.SetActive(true);
        transform.Rotate(Vector3.left * 90);
    }
    public void TaskOnClickRight()
    {
        leftbuton.SetActive(false);
        rigtbuton.SetActive(false);
        apbuton.SetActive(true);
        dawnbuton.SetActive(true);
    }
    public void TaskOnClickUp()
    {
        apbuton.SetActive(false);
        dawnbuton.SetActive(false);
        leftbuton.SetActive(true);
        rigtbuton.SetActive(true);
    }
    public void TaskOnClickDown()
    {
        apbuton.SetActive(false);
        dawnbuton.SetActive(false);
        leftbuton.SetActive(true);
        rigtbuton.SetActive(true);
    }
}
