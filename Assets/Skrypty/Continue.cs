using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{
    GameObject Snik;
    GameObject Przycisk;
    void Start()
    {
        Snik = GameObject.Find("Snake");
        Przycisk = GameObject.Find("Canvas/Continue");
        transform.position = new Vector3(x: 1, y: 2, z: 3);
    }
    
}