using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float acceleration = 5f;
    private Rigidbody2D rb;
    // sets up our Rigidbody2D component for movement
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // For acceleration-based movement (e.g., player input control)
    public void Move(float speed, Vector2 direction)
    {
        rb.velocity = direction * acceleration;
    }

    // For constant speed movement (e.g., enemies)
    public void MoveConstantSpeed(float speed, Vector2 direction)
    {
        if (rb == null)
            rb = GetComponent<Rigidbody2D>();

        rb.velocity = direction.normalized * speed;
    }

}
