using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    // Winning game sound
    public AudioClip winGameSound;
    // Game Over Score Text
    public Text gameOverScoreText;
    // Game Over Time Text
    public Text gameOverTimeText;
    // Game Over All or Nothing Text
    public Text gameAllOrNothingScoreText;

    private AudioSource audioSource = new AudioSource();

    private void Start()
    {
        // Get a reference to the AudioSource attached to GameObject
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // If the Player(Ball) impacts the collider at end of maze
        // and there is still time on the clock
        if (CountDown.timeLeft > 0.0)
        {
            // Play winning sound
            audioSource.PlayOneShot(winGameSound);

            // Show the Quit Canvas
            Canvas quitCanvas = GameObject.FindWithTag("QuitCanvas").GetComponent<Canvas>();
            quitCanvas.enabled = true;

            // Set values for Score, All or Nothing, and Time Left
            gameOverScoreText.text = $"Score: {Game.score}";
            gameAllOrNothingScoreText.text = $"All or Nothing Score: {Game.allOrNothingScore}";
            gameOverTimeText.text = $"Time: {Game.formatedTime}";
        }
    }
}
