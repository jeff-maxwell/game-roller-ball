using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGameScreen : MonoBehaviour
{
    private Game gameScript = new Game();

    public void OnQuitGameClick()
    {
        // Quit the Game
        Application.Quit();
    }

    public void OnAllOrNothingClick()
    {
        // Increment the All or Nothing Score and display it
        Game.allOrNothingScore += Game.score;
        Text allOrNothingText = GameObject.FindWithTag("AllOrNothingText").GetComponent<Text>();
        allOrNothingText.text = $"All Or Nothing: {Game.allOrNothingScore}";

        // Reset the Score for the next game and display it
        Game.score = 0;
        Text scoreText = GameObject.FindWithTag("GameScoreText").GetComponent<Text>();
        scoreText.text = $"Score: {Game.score}";

        // Increament the round count
        Game.round++;
        // Call the ResetGame to reset everything and start a new game
        gameScript.ResetGame();
    }
}
