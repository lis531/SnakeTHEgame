using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class score : MonoBehaviour
{
    public static int scoreAmount;
    private Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreAmount = 0;
    }
    void Update()
    {
        scoreText.text = "Score:" + scoreAmount;
    }
}
