using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject Snik;
    GameObject Przycisk;
    void Start()
    {
        Snik = GameObject.Find("Snake");
        Przycisk = GameObject.Find("Canvas/Continue");
        transform.position = new Vector3(1, 2, 3);
    }
    
}