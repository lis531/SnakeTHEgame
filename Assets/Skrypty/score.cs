using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public GameObject Score;
    public int scoreAmount;
    Text scoreText;

    public GameObject HighScore;
    public int highscore;
    Text highscoreText;
    
    void Awake()
    {
        highscoreText = HighScore.GetComponent<Text>();
        scoreText = Score.GetComponent<Text>();
        scoreAmount = 0;
        highscore = PlayerPrefs.GetInt("HIGHSCORE");
        highscoreText.text = "HIGHSCORE: " + highscore;
    }

    void FixedUpdate()
    {
        scoreText.text = "SCORE: " + scoreAmount;
        if(scoreAmount > highscore) highscore = scoreAmount;
        highscoreText.text = "HIGHSCORE:" + highscore;
        PlayerPrefs.SetInt("HIGHSCORE", highscore);
    }
}