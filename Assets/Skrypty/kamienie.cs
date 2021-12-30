using System.Collections;
using UnityEngine;
public class Kamienie : MonoBehaviour
{
    public BoxCollider2D pole;
    public float czas;
    GameObject MenuButton;
    GameObject RestartButton;
    GameObject ContinueButton;
    IEnumerator Amugus()
    {
        yield return new WaitForSeconds(czas);
        RandomizePosition();
    }
    void Start()
    {
        //copy skalka object 5 times
        for (int i = 0; i < 5; i++)
        {
            GameObject kamien = Instantiate(gameObject);
            kamien.transform.position = new Vector3(0, 0, 0);
            kamien.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            kamien.transform.parent = transform;
        }
        StartCoroutine(Amugus());
    }
    public void RandomizePosition()
    {
        Bounds bounds = this.pole.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);

        if (gameObject.tag.Equals("skalka"))
        {
            RandomizePosition();
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("skalka"))
        {
            MenuButton.SetActive(true);
            RestartButton.SetActive(true);
            ContinueButton.SetActive(true);
        }
    }
}