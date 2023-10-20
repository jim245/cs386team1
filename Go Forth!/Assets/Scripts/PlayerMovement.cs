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
    private bool isOnGround;

    // Start is called before the first frame update
   /* void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        // Acquires input
        input = Input.GetAxisRaw("Horizontal");

        // Flips sprite to match horizontal movement
        if(input < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if(input > 0)
        {
            spriteRenderer.flipX = false;
        }

        // Checks if knight is grounded
        isOnGround = Physics2D.OverlapCircle(feetPosition.position, feetSize, groundLayer);

        // Allows jumping
        if(isOnGround && Input.GetButton("Jump"))
        {
            playerRigidBody.velocity = Vector2.up * jumpForce;
        }
    }

    // Set to run 50 times per second to allow steady movement
    void FixedUpdate()
    {
        // Moves player on the x-axis
        playerRigidBody.velocity = new Vector2(input * speed, playerRigidBody.velocity.y);
    }
}
