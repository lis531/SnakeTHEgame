using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class score : MonoBehaviour
{
    private int currentScore;
    public TMP_Text scoreText;
    private void Update()
    {
        currentScore = 0;
    }
    private void Start()
    {
        gameObject.tag = "scorus";
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "scorus");
        {
            currentScore++;
            scoreText.text = "Score:" + currentScore;
        }
    }
}
