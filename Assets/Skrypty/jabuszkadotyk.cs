using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jabuszkadotyk : MonoBehaviour
{  
    score amogus;
    GameObject napisy;
    GameObject jabuszko;
    public BoxCollider2D pole;

    private void Start()
    {
        amogus = GameObject.Find("Score/Text").GetComponent<score>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        RandomizePosition();
        amogus.scoreAmount += 1;
        GameObject.Find("Snake/glowa").GetComponent<TrailRenderer>().time += 0.6f;
    }
    private void RandomizePosition()
    {
        Bounds bounds = this.pole.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }
}