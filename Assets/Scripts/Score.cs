using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    public void IncrementScore()
    {
        // Increase the score and set the value in the text 
        scoreText.text = $"Score: {++Game.score}";
    }
}
