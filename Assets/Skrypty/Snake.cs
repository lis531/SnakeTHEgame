using UnityEngine;
using UnityEngine.UI;

public class Snake : MonoBehaviour
{
    GameObject rigtbuton;
    GameObject leftbuton;
    GameObject przycisk;
    GameObject napisy;
    GameObject napisy1;
    GameObject napisy2;
    GameObject napisy3;

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
        napisy1 = GameObject.Find("Restart");
        napisy2 = GameObject.Find("Continue");
        napisy3 = GameObject.Find("Menu");

        napisy.SetActive(false);
        napisy1.SetActive(false);
        napisy2.SetActive(false);
        napisy3.SetActive(false);
        rigtbuton.SetActive(false);
        leftbuton.SetActive(false);

        Button btn = rozpoczecie.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        przycisk = GameObject.Find("Button");
    }
    private void TaskOnClick()
    {
        kobra = true;
        Destroy(przycisk);
        rigtbuton.SetActive(true);
        leftbuton.SetActive(true);
    }

    void FixedUpdate()
    {
        if (kobra == true)
        {
            transform.Translate(Vector2.up * currentspeed / 100);
        }
    }
}