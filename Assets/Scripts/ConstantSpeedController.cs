using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantSpeedController : MonoBehaviour
{
    [SerializeField]
    private float initialVelocity = 2f;
    [SerializeField]
    private Vector2 direction;
    [SerializeField]
    private bool useLocalDirection = false;
    private Movement movement;
    // calling the Movement component to set our velocity every frame for constant movement
    void Start()
    {
        movement = GetComponent<Movement>();
    }

    // Sends a constant velocity to the Movement component every frame for constant movement
    void Update()
    {
        Vector2 moveDirection = useLocalDirection ? transform.TransformDirection(direction) : direction;
        movement.MoveConstantSpeed(initialVelocity, moveDirection);
    }
}
