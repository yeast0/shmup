using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{



    int score = 0;
    Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("scoreText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore(int amountToAdd)
    {
        score += amountToAdd;
        scoreText.text = score.ToString();
    }
}
