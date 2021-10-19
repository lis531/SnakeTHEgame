using System.Collections;
using UnityEngine;
public class Kamienie : MonoBehaviour
{
    public BoxCollider2D pole;
    public float czas1;
    public float czas2;
    public float czas3;
    public float czas4;
    IEnumerator Amugus()
    {
        yield return new WaitForSeconds(czas1);
        RandomizePosition();
    }
    IEnumerator Amugu()
    {
        yield return new WaitForSeconds(czas2);
        RandomizePositio();
    }
    IEnumerator Amug()
    {
        yield return new WaitForSeconds(czas3);
        RandomizePositi();
    }
    IEnumerator Amu()
    {
        yield return new WaitForSeconds(czas4);
        RandomizePosit();
    }
    IEnumerator Am()
    {
        yield return new WaitForSeconds(czas4);
        RandomizePosi();
    }

    void Start()
    {
        StartCoroutine(Amugus());
        StartCoroutine(Amugu());
        StartCoroutine(Amug());
        StartCoroutine(Amu());
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
        if (gameObject.tag.Equals("skalka"))
        {
            RandomizePosition();
        }
        if (gameObject.tag.Equals("skalka1"))
        {
            RandomizePosition();
        }
        if (gameObject.tag.Equals("skalka2"))
        {
            RandomizePosition();
        }
        if (gameObject.tag.Equals("skalka3"))
        {
            RandomizePosition();
        }
        if (gameObject.tag.Equals("skalka4"))
        {
            RandomizePosition();
        }
    }
    public void RandomizePositio()
    {
        Bounds bounds = this.pole.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);

        if (gameObject.tag.Equals("skalka"))
        {
            RandomizePositio();
        }
        if (gameObject.tag.Equals("skalka"))
        {
            RandomizePositio();
        }
        if (gameObject.tag.Equals("skalka1"))
        {
            RandomizePositio();
        }
        if (gameObject.tag.Equals("skalka2"))
        {
            RandomizePositio();
        }
        if (gameObject.tag.Equals("skalka3"))
        {
            RandomizePositio();
        }
        if (gameObject.tag.Equals("skalka4"))
        {
            RandomizePositio();
        }
    }
    public void RandomizePositi()
    {
        Bounds bounds = this.pole.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);

        if (gameObject.tag.Equals("skalka"))
        {
            RandomizePositi();
        }
        if (gameObject.tag.Equals("skalka"))
        {
            RandomizePositi();
        }
        if (gameObject.tag.Equals("skalka1"))
        {
            RandomizePositi();
        }
        if (gameObject.tag.Equals("skalka2"))
        {
            RandomizePositi();
        }
        if (gameObject.tag.Equals("skalka3"))
        {
            RandomizePositi();
        }
        if (gameObject.tag.Equals("skalka4"))
        {
            RandomizePositi();
        }
    }
    public void RandomizePosit()
    {
        Bounds bounds = this.pole.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);

        if (gameObject.tag.Equals("skalka"))
        {
            RandomizePosit();
        }
        if (gameObject.tag.Equals("skalka"))
        {
            RandomizePosit();
        }
        if (gameObject.tag.Equals("skalka1"))
        {
            RandomizePosit();
        }
        if (gameObject.tag.Equals("skalka2"))
        {
            RandomizePosit();
        }
        if (gameObject.tag.Equals("skalka3"))
        {
            RandomizePosit();
        }
        if (gameObject.tag.Equals("skalka4"))
        {
            RandomizePosit();
        }
    }
    public void RandomizePosi()
    {
        Bounds bounds = this.pole.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);

        if (gameObject.tag.Equals("skalka"))
        {
            RandomizePosi();
        }
        if (gameObject.tag.Equals("skalka"))
        {
            RandomizePosi();
        }
        if (gameObject.tag.Equals("skalka1"))
        {
            RandomizePosi();
        }
        if (gameObject.tag.Equals("skalka2"))
        {
            RandomizePosi();
        }
        if (gameObject.tag.Equals("skalka3"))
        {
            RandomizePosi();
        }
        if (gameObject.tag.Equals("skalka4"))
        {
            RandomizePosi();
        }
    }
}