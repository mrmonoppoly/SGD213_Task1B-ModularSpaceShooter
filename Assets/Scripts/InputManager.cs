using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Movement movement;
    private ShootingScript shooting;


    void Start()
    {
        // Gets the movement and shooting scripts so we can send input to them
        movement = GetComponent<Movement>();
        shooting = GetComponent<ShootingScript>();
    }

    void Update()
    {
        // Collects the input from the player and sends it to the movement and shooting scripts
        float horizontalInput = Input.GetAxis("Horizontal");
        movement.Move(5f, Vector2.right * horizontalInput);

        if (Input.GetButton("Fire1"))
        {
            shooting.Shoot();
        }
    }
}
