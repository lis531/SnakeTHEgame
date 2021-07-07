using UnityEngine;
using UnityEngine.UI;

public class Snake : MonoBehaviour
{
    GameObject rigtbuton;
    GameObject leftbuton;
    GameObject przycisk;
    GameObject napisy;
    GameObject napisy2;
    public Vector2 _direction;
    public Button rozpoczecie;
    float currentspeed = 2f;
    bool kobra = false;
    GameObject poczatek;
    private GameObject snake;
    private void Start()
    {
        rigtbuton = GameObject.Find("Button right");
        leftbuton = GameObject.Find("Button left");
        napisy = GameObject.Find("Score");
        napisy2 = GameObject.Find("After death");
        napisy.SetActive(false);
        napisy2.SetActive(false);
        rigtbuton.SetActive(false);
        leftbuton.SetActive(false);
        Button btn = rozpoczecie.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        przycisk = GameObject.Find("Button");
    }
    private void TaskOnClick()
    {
        _direction = Vector2.up;
        kobra = true;
        Destroy(przycisk);
        rigtbuton.SetActive(true);
        leftbuton.SetActive(true);
    }

    void FixedUpdate()
    {
        if (kobra == true)
        {
            transform.Translate(_direction * currentspeed / 100);
        }
    }
}