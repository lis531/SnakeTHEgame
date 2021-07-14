using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class score : MonoBehaviour
{
    public GameObject skoreText;
    public int scoreAmount;
    private TMP_Text scoreText;
    public int highscore;
    private TMP_Text highscoreText;
    public GameObject HighScore;
    
    void Awake()
    {
        highscoreText = HighScore.GetComponent<TMP_Text>();
        scoreText = skoreText.GetComponent<TMP_Text>();
        scoreAmount = 0;
        highscore = PlayerPrefs.GetInt("HightScore");
        highscoreText.text = "HighScore:" + highscore;
    }
    void FixedUpdate()
    {
        scoreText.text = "" + scoreAmount;
        if(scoreAmount > highscore) highscore = scoreAmount;
        highscoreText.text = "HighScore:" + highscore;
        PlayerPrefs.SetInt("HightScore", highscore);
    }
}