using UnityEngine;
using UnityEngine.UI;

public class jabuszkarespawn : MonoBehaviour
{
    public BoxCollider2D pole;
    public Button rozpoczecie;
    GameObject poczatek;
    GameObject przycisk;
    GameObject jabuszko;

    private void Start()
    {
        jabuszko = gameObject;
        jabuszko.SetActive(false);
        Button btn = rozpoczecie.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        przycisk = GameObject.Find("Button");
    }

    private void TaskOnClick()
    {
        jabuszko.SetActive(true);
        RandomizePosition();
    }

    private void RandomizePosition()
    {
        Bounds bounds = this.pole.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Gracz")
        {
            RandomizePosition();
        }
    }
}