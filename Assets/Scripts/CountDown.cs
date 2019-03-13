using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    /************************
     * Global Variables
     ***********************/
    // Initialize the time left to 90 seconds
    public static float timeLeft = 90f;
    // Initial time
    public static float initialTime = 90f;
    // Time Left Text
    public Text timeLeftText;
    // Game Over Time Text
    public Text gameOverTimeText;
    // Game Over Score Text
    public Text gameOverScoreText;
    // Game Over Sound Clip
    public AudioClip gameOverSound;

    // Amount to decrease time per round
    private static float decreaseTime = 30f;
    // Time Started Boolean to keep track if the timer is started
    private static bool timerStarted;
    // Audio Source
    private AudioSource audioSource;

    void Start()
    {
        // Get reference to Audio Source
        audioSource = GetComponent<AudioSource>();
        // Initally set timer to false (Stopped)
        timerStarted = false;
    }

    public void StartCountDownTime()
    {
        // Set timer to true to start timer
        timerStarted = true;

        // Time Left = Initial Time - (Current Round * Amount of time to decrease)
        // EXAMPLE: 30 = 90 - (2 * 30)
        timeLeft = initialTime - (Game.round * decreaseTime);
    }

    void Update()
    {
        print(timerStarted);

        if (timerStarted)
        {
            // Display the current time left
            timeLeft -= 1 * Time.deltaTime;
            timeLeftText.text = $"Time Left: {FormatTime()}";
            Game.formatedTime = timeLeftText.text;

            if (timeLeft <= 0)
            {
                // Stop the timer (false)
                timerStarted = false;
                // Set default time string
                timeLeftText.text = $"Time Left: 00:00";
                // Play game over sound
                audioSource.PlayOneShot(gameOverSound);
                // Get reference to Game Over Canvas and make it visible
                Canvas gameOverCanvas = GameObject.FindWithTag("GameOverCanvas").GetComponent<Canvas>();
                gameOverCanvas.enabled = true;

                // Set the Formated time
                Game.formatedTime = timeLeftText.text;
                // Set the Game Over Score
                gameOverScoreText.text = $"Score: {Game.score}";
                // Set the Game Over Time Text
                gameOverTimeText.text = $"Time: {Game.formatedTime}";
            }

        }
    }

    // Format the time to minutes:seconds
    // EXAMPLE: 65 seconds = 1:05
    private string FormatTime()
    {
        string minutes = "0";
        string seconds = "00";
        // Format the clock time
        if (timeLeft > 60) 
            minutes = (timeLeft / 60).ToString("0");

        seconds = (timeLeft % 60).ToString("0");
        seconds = seconds.PadLeft(2, '0');

        return $"{minutes}:{seconds}";
    }
}
