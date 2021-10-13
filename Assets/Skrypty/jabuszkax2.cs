using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jabuszkax2 : MonoBehaviour
{
    score ScoreText;
    public BoxCollider2D pole;
    GameObject jabuszkox2;

    private void Start()
    {
        jabuszkox2 = GameObject.Find("jabuszkozlote");
        ScoreText = GameObject.Find("Canvas/Score").GetComponent<score>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("Snake/glowa").GetComponent<TrailRenderer>().time += 1.0f;
        ScoreText.scoreAmount += 3;
        jabuszkox2.SetActive(false);
        RandomizePosition();

    }
    public void RandomizePosition()
    {
        IEnumerator DelayAction(float delayTime)
        {
            yield return new WaitForSeconds(10);
            jabuszkox2.SetActive(true);
            Bounds bounds = this.pole.bounds;

            float x = Random.Range(bounds.min.x, bounds.max.x);
            float y = Random.Range(bounds.min.y, bounds.max.y);

            this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
        }
    }
}
