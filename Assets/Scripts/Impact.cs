using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact : MonoBehaviour
{
    // Refrence to the Score Script
    private Score scoreScript = new Score();
    // AudioSource to play sound on impact
    private AudioSource audioSource;

    private void Start()
    {
        // Get the reference to the AudioSource
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // If the Player(Ball) collides with a Cube(GameCube)
        if ((collision.gameObject.tag.Equals("Player")) && (gameObject.tag.Equals("GameCube")))
        {
            // Get a Reference to the Score HUD
            GameObject canvas = GameObject.FindWithTag("MainCanvas");
            scoreScript = canvas.GetComponent<Score>();

            // Increment the Score
            scoreScript.IncrementScore();

            // Play the impact sound
            audioSource.Play();

            // Destory/Remove the Cube
            Destroy(gameObject);
        }
    }
}   
