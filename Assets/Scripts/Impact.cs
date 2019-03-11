using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact : MonoBehaviour
{
    private Score scoreScript = new Score();
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            GameObject canvas = GameObject.FindWithTag("MainCanvas");

            scoreScript = canvas.GetComponent<Score>();
            scoreScript.IncrementScore();

            audioSource.Play();

            Destroy(gameObject);
        }
    }
}   
