using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRSkrypt : MonoBehaviour
{
    public GameObject ColliderPrefab;
    TrailRenderer tr;

    void Awake()
    {
        tr = GameObject.Find("Snake/glowa").GetComponent<TrailRenderer>();
    } 
    public void AddCollider()
    {
        GameObject newCollider = Instantiate(ColliderPrefab, transform.position, Quaternion.Euler(0, 0, 0));
        Destroy(newCollider, tr.time);
    }
}