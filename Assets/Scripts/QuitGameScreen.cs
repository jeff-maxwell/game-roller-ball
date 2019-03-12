using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGameScreen : MonoBehaviour
{
    private StartCountDown startCountDownScript = new StartCountDown();

    public void OnQuitGameButton()
    {
        print("Quit Game");
        Application.Quit();
    }

    public void OnPlayAgainButton()
    {
        print("Play Again");
//        Game.score = 0;
//        startCountDownScript.StartCountDownTime(90);
    }
}
