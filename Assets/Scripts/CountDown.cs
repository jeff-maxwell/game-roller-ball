using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    // Initialize the time left to 90 seconds
    public static float timeLeft = 90f;
    public Text timeLeftText;
    public AudioClip gameOverSound;

    private static bool timerStarted;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        timerStarted = false;
        //StartCountDownTime(90);
    }

    public void StartCountDownTime(int countTime)
    {
        timerStarted = true;
        timeLeft = countTime;
    }

    // Update is called once per frame
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
                timerStarted = false;
                timeLeftText.text = $"Time Left: 00:00";
                audioSource.PlayOneShot(gameOverSound);
                GameObject quitCanvas = GameObject.FindWithTag("QuitCanvas");
                var quitCanvasGroup = quitCanvas.GetComponent<CanvasGroup>();
                quitCanvasGroup.alpha = 1f;
                Game.formatedTime = timeLeftText.text;
                //exitGameScript.GameOver();
            }

        }
    }

    private string FormatTime()
    {
        // Format the clock time
        string minutes = (timeLeft / 60).ToString("0");
        string seconds = (timeLeft % 60).ToString("0");
        seconds = seconds.PadLeft(2, '0');

        return $"{minutes}:{seconds}";
    }
}
