using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{


    public int score = 0;
    public int highScore = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    

    public void addScore()
    {
        score+= 1;
        // adds one to player 

        Debug.Log("yup it worked");
        Debug.Log("score is" + score);
        scoreText.text = score.ToString();
        // makes the score text update
        if (highScore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }



    }


    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore", 0);
        highScoreText.text = highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
