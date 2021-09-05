using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    Camera cam;
    GameObject MenuButton;
    GameObject RestartButton;
    GameObject ContinueButton;
    GameObject LeftButton;
    GameObject RightButton;
    GameObject UpButton;
    GameObject DownButton;

    private void Start()
    {
        MenuButton = GameObject.Find("Menu");
        RestartButton = GameObject.Find("Restart");
        ContinueButton = GameObject.Find("Continue");
        LeftButton = GameObject.Find("Button left");
        RightButton = GameObject.Find("Button right");
        UpButton = GameObject.Find("Button up");
        DownButton = GameObject.Find("Button down");
        MenuButton.SetActive(false);
        RestartButton.SetActive(false);
        ContinueButton.SetActive(false);
    }

    private void Awake()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        InvokeRepeating("CheckVisibility", 0, 0.3f);
    }

    void CheckVisibility()
    {
        Vector3 screenPoint = cam.WorldToViewportPoint(transform.position);
        bool onScreen = screenPoint.z > 0 && screenPoint.x > 0 && screenPoint.x < 1 && screenPoint.y > 0 && screenPoint.y < 1;
        if(!onScreen)
        {
            Destroy(gameObject);
            MenuButton.SetActive(true);
            RestartButton.SetActive(true);
            ContinueButton.SetActive(true);
            LeftButton.SetActive(false);
            RightButton.SetActive(false);
            UpButton.SetActive(false);
            DownButton.SetActive(false);
        }
    }
}
