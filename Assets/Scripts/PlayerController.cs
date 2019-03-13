using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Rigid Body attached to Player(Ball)
    private Rigidbody rb;
    // Move speed of the Player(Ball)
    public float MoveSpeed = 1.0f;

    private void Start()
    {
        // Get reference to Rigid body attached to Player(Ball)
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Get the Horizontal Movement of the Player(Ball)
        float moveHorizontal = Input.GetAxis("Horizontal");
        // Get the Vertical Movement of the Player(Ball)
        float moveVertical = Input.GetAxis("Vertical");

        // Get the changed movement of the GameObject
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Add force on GameObject Player(Ball)
        rb.AddForce(movement * MoveSpeed);
    }
}
