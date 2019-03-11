using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGameScreen : MonoBehaviour
{
    public Text scoreText;
    public Text timeLeftText;

    private void Start()
    {
        scoreText.text = $"Score: {Game.score}";
        timeLeftText.text = $"Time: {Game.formatedTime}";
    }

    public void OnQuitGameButton()
    {
        print("Quit Game");
        Application.Quit();
    }
}
