using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    private int currentScore;
    public Text scoreText;
    private void Update()
    {
        currentScore = 0;
    }
    private void Start()
    {
        gameObject.tag = "scorus";
    }
    private void HandleScore ()
    {
        scoreText.text = "Score:" + currentScore;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag = "scorus");
        {
            currentScore = 1;
            currentScore ++;
        }
    }
}
