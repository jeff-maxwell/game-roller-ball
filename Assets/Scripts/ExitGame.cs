using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public AudioClip winGameSound;
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
        }
    }

    public void WinGame()
    {
        audioSource.PlayOneShot(winGameSound);
    }
}
