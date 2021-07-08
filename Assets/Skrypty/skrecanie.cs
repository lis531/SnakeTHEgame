using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class skrecanie : MonoBehaviour
{
    private Vector2Int gridMoveDirection;
    private Vector2Int gridPosition;
    private float gridMoveTimer;
    private float gridMoveTimerMax;
    GameObject apbuton;
    GameObject dawnbuton;
    GameObject rigtbuton;
    GameObject leftbuton;
    GameObject Snake;

    void Awake()
    {
        gridPosition = new Vector2Int(0, 0);
        gridMoveTimerMax = 1f;
        gridMoveTimer = gridMoveTimerMax;
        gridMoveDirection = new Vector2Int(1, 0);
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
        //Snake.transform.rotation = Quaternion.Euler(0, 0, 90);
        leftbuton.SetActive(false);
        rigtbuton.SetActive(false);
        apbuton.SetActive(true);
        dawnbuton.SetActive(true);
        gridPosition.x -= 1;
    }
    public void TaskOnClickRight()
    {
        //Snake.transform.rotation = Quaternion.Euler(0, 0, -90);
        leftbuton.SetActive(false);
        rigtbuton.SetActive(false);
        apbuton.SetActive(true);
        dawnbuton.SetActive(true);
        gridPosition.x += 1;
    }
    public void TaskOnClickUp()
    {
        //Snake.transform.rotation = Quaternion.Euler(0, 0, 0);
        apbuton.SetActive(false);
        dawnbuton.SetActive(false);
        leftbuton.SetActive(true);
        rigtbuton.SetActive(true);
        gridPosition.y += 1;
    }
    public void TaskOnClickDown()
    {
        //Snake.transform.rotation = Quaternion.Euler(0, 0, 180);
        apbuton.SetActive(false);
        dawnbuton.SetActive(false);
        leftbuton.SetActive(true);
        rigtbuton.SetActive(true);
        gridPosition.y -= 1;
    }

    private void Update() {
        gridMoveTimer += Time.deltaTime;
        if (gridMoveTimer >= gridMoveTimerMax) {
            gridPosition += gridMoveDirection;
            gridMoveTimer -= gridMoveTimerMax;
        }
        transform.position = new Vector3(gridPosition.x, gridPosition.y);
    }
}
