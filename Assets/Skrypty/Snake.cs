using UnityEngine;
using UnityEngine.UI;

public class Snake : MonoBehaviour
{
    GameObject rigtbuton;
    GameObject leftbuton;
    GameObject przycisk;
    public Button rozpoczecie;
    float currentspeed = 3f;
    bool kobra = false;
    GameObject poczatek;
    private GameObject snake;
    private void Start()
    {
        rigtbuton = GameObject.Find("Button right");
        leftbuton = GameObject.Find("Button left");
        Button btn = rozpoczecie.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        przycisk = GameObject.Find("Button");
    }
    float dom;
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
            transform.Translate(transform.up * currentspeed / 100);
        }
    }
}