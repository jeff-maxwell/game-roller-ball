using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    public AudioClip winGameSound;
    public Text gameOverScoreText;
    public Text gameOverTimeText;
    private AudioSource audioSource = new AudioSource();

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (CountDown.timeLeft > 0.0)
        {
            WinGame();

            GameObject quitCanvas = GameObject.FindWithTag("QuitCanvas");
            var quitCanvasGroup = quitCanvas.GetComponent<CanvasGroup>();
            quitCanvasGroup.alpha = 1f;
            gameOverScoreText.text = $"Score: {Game.score}";
            gameOverTimeText.text = $"Time: {Game.formatedTime}";
        }
    }

    public void WinGame()
    {
        audioSource.PlayOneShot(winGameSound);
    }
}
