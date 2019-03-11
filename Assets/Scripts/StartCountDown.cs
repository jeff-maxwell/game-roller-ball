using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCountDown : MonoBehaviour
{
    // Initialize the time left to 90 seconds
    public float timeLeft = 3.0f;
    public Text timeLeftText;

    private CountDown countDownScript = new CountDown();
    private string formatedTime;
    private bool timeStarted = true;

    void Start()
    {
        StartCountDownTime(3);
    }

    public void StartCountDownTime(int countTime)
    {
        timeLeft = countTime;
        timeStarted = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeStarted)
        {
            timeLeft -= 1 * Time.deltaTime;
            timeLeftText.text = timeLeft.ToString("0");
            if (timeLeft <= 1 && timeLeft > 0)
                timeLeftText.text = "Go!!!!";

            if (timeLeft <= 0)
            {
                timeStarted = false;
                GameObject countDownCanvas = GameObject.FindWithTag("CountDownCanvas");
                countDownCanvas.SetActive(false);

                countDownScript.StartCountDownTime(5);
            }
        }
    }
}
