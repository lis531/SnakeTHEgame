//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class Continue : MonoBehaviour
//{
//    GameObject Snik;
//    GameObject MenuButton;
//    GameObject RestartButton;
//    GameObject ContinueButton;
//    void Start()
//    {
//        Snik = GameObject.Find("Snake");
//        MenuButton = GameObject.Find("Canvas/Menu");
//        RestartButton = GameObject.Find("Canvas/Restart");
//        ContinueButton = GameObject.Find("Canvas/Continue");
//    }
//    public void ContinueButtonPressed()
//    {
//        ContinueButton.SetActive(false);
//        RestartButton.SetActive(false);
//        MenuButton.SetActive(false);
//        Snik.transform.position = new Vector3(0, 0, 0);
//    }
//}