using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    Game gameScript = new Game();

    public void OnQuitGame()
    {
        // Quit the Game
        Application.Quit();
    }

    public void OnPlayAgain()
    {
        // Reset the All or Nothing Score and display it
        Game.allOrNothingScore = 0;
        Text allOrNothingText = GameObject.FindWithTag("AllOrNothingText").GetComponent<Text>();
        allOrNothingText.text = $"All Or Nothing: {Game.allOrNothingScore}";

        // Reset the game score and display it
        Game.score = 0;
        Text scoreText = GameObject.FindWithTag("GameScoreText").GetComponent<Text>();
        scoreText.text = $"Score: {Game.score}";

        // Reset the Current round to ZERO (0)
        Game.round = 0;
        // Reset everything and start a new game.
        gameScript.ResetGame();
    }
}
