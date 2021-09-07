using UnityEngine;

public class jabuszkadotyk : MonoBehaviour
{  
    score ScoreText;
    public BoxCollider2D pole;

    private void Start()
    {
        ScoreText = GameObject.Find("Canvas/Score").GetComponent<score>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        RandomizePosition();
        ScoreText.scoreAmount += 1;
        GameObject.Find("Snake/glowa").GetComponent<TrailRenderer>().time += 0.4f;
    }
    private void RandomizePosition()
    {
        Bounds bounds = this.pole.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }
}