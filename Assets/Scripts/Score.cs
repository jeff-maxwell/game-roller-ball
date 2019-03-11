using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    // Default the score to 0
    private int score = 0;

    public void IncrementScore()
    {
        // Increase the score and set the value in the text 
        scoreText.text = $"Score: {++score}";
        Game.score = score;
    }
}
