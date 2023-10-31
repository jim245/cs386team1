using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variables
    public Rigidbody2D playerRigidBody;
    public SpriteRenderer spriteRenderer;
    public Transform feetPosition;  // Used to check if knight is grounded
    public LayerMask groundLayer;   // Allows identification of what's considered to be the ground
    public float speed;
    public float input;
    public float jumpForce;
    public float feetSize;
    public float jumpTime = 0.25f;  // Total value of time knight can be in the air
    public float jumpTimeCounter;
    public bool isOnGround;
    public bool isJumping;

    // Update is called once per frame
    public void Update()
    {
        // Acquires input
        input = Input.GetAxisRaw("Horizontal");

        // Flips sprite to match horizontal movement
        if (input < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (input > 0)
        {
            spriteRenderer.flipX = false;
        }

        // Allows jumping
        JumpCheck();
    }

    // Set to run 50 times per second to allow steady movement
    public void FixedUpdate()
    {
        // Moves player on the x-axis
        playerRigidBody.velocity = new Vector2(input * speed, playerRigidBody.velocity.y);
    }

    // Player jumps if spacebar is pressed
    public void JumpCheck()
    {
        // Checks if knight is grounded
        isOnGround = Physics2D.OverlapCircle(feetPosition.position, feetSize, groundLayer);

        if (isOnGround && Input.GetButtonDown("Jump"))
        {
            // Starts jump timer (for holding down space bar)
            isJumping = true;
            jumpTimeCounter = jumpTime;

            // Jumps
            playerRigidBody.velocity = Vector2.up * jumpForce;
        }

        // Continues jump while space button is held
        if (isJumping && Input.GetButton("Jump"))
        {
            if (jumpTimeCounter > 0)
            {
                playerRigidBody.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;  // Lowers counter
            }
            else
            {
                isJumping = false;
            }
        }

        // Ends jump when spacebar lifted
        if (!Input.GetButton("Jump"))
        {
            isJumping = false;
        }
    }
}
