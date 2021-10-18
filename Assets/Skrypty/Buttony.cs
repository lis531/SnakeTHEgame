using UnityEngine;
using UnityEngine.UI;

public class Buttony : MonoBehaviour
{
    GameObject rightbutton;
    GameObject leftbutton;
    GameObject przycisk;
    GameObject napisy;
    GameObject napisy1;
    GameObject napisy2;
    GameObject napisy3;
    public Button rozpoczecie;

    private void Start()
    {
        rightbutton = GameObject.Find("Button right");
        leftbutton = GameObject.Find("Button left");
        napisy = GameObject.Find("Score");
        napisy1 = GameObject.Find("Restart");
        napisy2 = GameObject.Find("Continue");
        napisy3 = GameObject.Find("Menu");
        napisy.SetActive(true);
        napisy1.SetActive(false);
        napisy2.SetActive(false);
        napisy3.SetActive(false);
        rightbutton.SetActive(false);
        leftbutton.SetActive(false);

        Button btn = rozpoczecie.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        przycisk = GameObject.Find("Button");
    }
    private void TaskOnClick()
    {
        Destroy(przycisk);
        rightbutton.SetActive(true);
        leftbutton.SetActive(true);
        napisy.SetActive(true);
    }
}