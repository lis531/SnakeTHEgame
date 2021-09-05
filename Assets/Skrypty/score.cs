using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public GameObject skoreText;
    public int scoreAmount;
    Text scoreText;

    public int highscore;
    Text highscoreText;
    public GameObject HighScore;
    
    void Awake()
    {
        highscoreText = HighScore.GetComponent<Text>();
        scoreText = skoreText.GetComponent<Text>();
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