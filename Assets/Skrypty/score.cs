using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public void RestartGame()
    {
        PlayerPrefs.SetInt("SCORE", scoreAmount);
        PlayerPrefs.SetInt("RESTARTONSTART", 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void FixedUpdate()
    {
        scoreText.text = "SCORE: " + scoreAmount;
        if (scoreAmount > highscore)
        {
            highscore = scoreAmount;
            highscoreText.text = "HIGHSCORE:" + highscore;
            PlayerPrefs.SetInt("HIGHSCORE", highscore);
        }
    }
}