using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the player's movement
    private Rigidbody2D rb; // Rigidbody2D component for the player
    private Animator animator; // Animator component to control animations
    private Vector2 movement; // Store the player's movement direction
    private bool isFacingRight = false; // Track the direction the player is facing

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Get the player's input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Update the animation based on movement
        UpdateAnimation();

        // Check which direction the player is moving and flip if necessary
        FlipSprite();
    }

    void FixedUpdate()
    {
        // Move the player
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void UpdateAnimation()
    {
        if (movement != Vector2.zero)
        {
            // If the player is moving, set the animation to "Run"
          //  animator.SetFloat("Horizontal", movement.x);
          //  animator.SetFloat("Vertical", movement.y);
            animator.SetBool("isMoving", true);
        }
        else
        {
            // If the player is not moving, set the animation to "Idle"
            animator.SetBool("isMoving", false);
        }
    }

    void FlipSprite()
    {
        // Check if the player is moving horizontally
        if (movement.x > 0 && !isFacingRight)
        {
            // Moving right, flip the sprite
            Flip();
        }
        else if (movement.x < 0 && isFacingRight)
        {
            // Moving left, flip the sprite
            Flip();
        }
    }

    void Flip()
    {
        // Flip the sprite's direction by inverting the local scale's X value
        isFacingRight = !isFacingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
