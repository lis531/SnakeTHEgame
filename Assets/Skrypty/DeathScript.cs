using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    Camera cam;

    private void Awake()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        InvokeRepeating("CheckVisibility", 0, 0.3f);
    }

    void CheckVisibility()
    {
        Vector3 screenPoint = cam.WorldToViewportPoint(transform.position);
        bool onScreen = screenPoint.z > 0 && screenPoint.x > 0 && screenPoint.x < 1 && screenPoint.y > 0 && screenPoint.y < 1;
        if(!onScreen)
        {
            Destroy(gameObject);
        }
    }
}
