using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variables
    public Rigidbody2D playerRigidBody;
    public float speed;
    public float input;

    // Start is called before the first frame update
   /* void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        // Acquires input
        input = Input.GetAxisRaw("Horizontal");
    }

    // Set to run 50 times per second to allow steady movement
    void FixedUpdate()
    {
        // Moves player on the x-axis
        playerRigidBody.velocity = new Vector2(input * speed, playerRigidBody.velocity.y);
    }
}
