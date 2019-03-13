using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCountDown : MonoBehaviour
{
    // Initialize time left
    public float timeLeft = 3.0f;
    private Text timeLeftText;

    // Reference to CountDown Script
    private CountDown countDownScript = new CountDown();
    // Time Started Boolean for Count Down
    private bool timeStarted = true;

    void Start()
    {
        // Initally call the Start Timer and start the count down clock
        StartCountDownTime(timeLeft);
    }

    public void StartCountDownTime(float countTime)
    {
        // Get a reference to the CountDownText UI element
        timeLeftText = GameObject.FindWithTag("CountDownText").GetComponent<Text>();
        timeLeft = countTime;
        timeStarted = true;
    }

    void Update()
    {
        if (timeStarted)
        {
            // Calculate the Time left decreasing by a second
            timeLeft -= 1 * Time.deltaTime;
            timeLeftText.text = timeLeft.ToString("0");

            // If the time left is less than a second show "Go!!!!"
            if (timeLeft <= 1 && timeLeft > 0)
                timeLeftText.text = "Go!!!!";

            // If the time has run out hide the count down canvas and start
            // the game timer
            if (timeLeft <= 0)
            {
                timeStarted = false;
                Canvas countDownCanvas = GameObject.FindWithTag("CountDownCanvas").GetComponent<Canvas>();
                countDownCanvas.enabled = false;

                countDownScript.StartCountDownTime();
            }
        }
    }
}
