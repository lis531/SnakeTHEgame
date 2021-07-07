using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class jabuszkadotyk : MonoBehaviour
{
    GameObject napisy;
    GameObject jabuszko;
    public BoxCollider2D pole;
    private void Start()
    {
        napisy = GameObject.Find("Score");

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        RandomizePosition();
        GameObject.Find("Score").GetComponent<Text>().text += 1;

    }


    private void RandomizePosition()
    {
        Bounds bounds = this.pole.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }
}
