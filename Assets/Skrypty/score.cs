using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class score : MonoBehaviour
{
    public static int scoreAmount;
    private TMP_Text scoreText;

    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        scoreAmount = 0;
    }
    void Update()
    {
        scoreText.text = "SCORE:" + scoreAmount;
    }
}
