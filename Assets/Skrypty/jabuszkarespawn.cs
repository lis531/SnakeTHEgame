using System.Collections;
using UnityEngine;

public class Jabuszkarespawn : MonoBehaviour
{
    score Score;
    public BoxCollider2D pole;
    IEnumerator Amogus()
    {
        yield return new WaitForSeconds(2.0f);
        RandomizePosition();
    }
    void Start()
    {
        StartCoroutine(Amogus());
        Score = GameObject.Find("Canvas/Score").GetComponent<score>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        transform.position = new Vector3(100, 100, 100);
        GameObject.Find("Snake/glowa").GetComponent<TrailRenderer>().time += 1.0f;
        Score.scoreAmount += 1;
        StartCoroutine(Amogus());
    }
    public void RandomizePosition()
    {
        Bounds bounds = this.pole.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }
}