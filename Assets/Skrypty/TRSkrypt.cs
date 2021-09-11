using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TRSkrypt : MonoBehaviour
{
    public GameObject ColliderPrefab;
    TrailRenderer tr;
    score scoreScript;
    GameObject snejk;
    GameObject MenuButton;
    GameObject RestartButton;
    GameObject ContinueButton;
    GameObject UpButton;
    GameObject DownButton;
    GameObject RightButton;
    GameObject LeftButton;


    void Awake()
    {
        scoreScript = GameObject.Find("Canvas/Score").GetComponent<score>();
        scoreScript.gameObject.SetActive(false);
        tr = GameObject.Find("Snake/glowa").GetComponent<TrailRenderer>();
        snejk = GameObject.Find("Canvas/Snake");
        UpButton = GameObject.Find("Canvas/Button up");
        DownButton = GameObject.Find("Canvas/Button down");
        RightButton = GameObject.Find("Canvas/Button right");
        LeftButton = GameObject.Find("Canvas/Button left");
        MenuButton = GameObject.Find("Canvas/Menu");
        RestartButton = GameObject.Find("Canvas/Restart");
        ContinueButton = GameObject.Find("Canvas/Continue");
        snejk = GameObject.Find("Snake");
    }
    IEnumerator ActivateOverTime(GameObject col)
    {
        yield return new WaitForSeconds(0.5f);
        col.SetActive(true);
    }
    public void AddCollider()
    {
        GameObject newCollider = Instantiate(ColliderPrefab, transform.position, Quaternion.Euler(0, 0, 0));
        newCollider.SetActive(false);

        StartCoroutine(ActivateOverTime(newCollider));

        Destroy(newCollider, tr.time);
    }
    //snejk.transform.position = new Vector3(0, 0, 0);
    //snejk.transform.rotation = Quaternion.Euler(0, 0, 0);
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.transform.CompareTag("Kolajder"))
        {
            scoreScript.RestartGame();
            snejk.SetActive(false);
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