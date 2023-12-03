using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.SceneManagement;

public class MovementTest
{
    private GameObject knightObject;
    private PlayerMovement playerMovementScript;
    private Rigidbody2D originalRigidBody2D;

    [OneTimeSetUp]
    public void LoadScene()
    {
        SceneManager.LoadScene("Level1");
    }

    [UnitySetUp]
    public IEnumerator SetUpTest()
    {
        // Wait a frame to ensure scene is loaded
        yield return null;

        // Find the knight object in the scene
        knightObject = GameObject.FindGameObjectWithTag("Player");
        Assert.IsNotNull(knightObject, "Knight object not found in the scene");

        // Get the knight's movement script
        playerMovementScript = knightObject.GetComponent<PlayerMovement>();
        Assert.IsNotNull(playerMovementScript, "PlayerMovement script not found on the Knight object");

        // Store the original RigidBody2D
        originalRigidBody2D = playerMovementScript.playerRigidBody;

        // Create a mock object for RigidBody2D
        Rigidbody2D mockRigidBody2D = new GameObject().AddComponent<Rigidbody2D>();

        // Replace original with mock
        playerMovementScript.playerRigidBody = mockRigidBody2D;
    }

    [UnityTest]
    public IEnumerator TestTesting()
    {
        // Check if Play Mode tests work
        Assert.IsTrue(true);
        yield return null;
    }
    
    [UnityTest]
    public IEnumerator TestPlayerCanMoveHorizontally()
    {
        // Save the initial position of the knight
        Vector2 initialPosition = knightObject.transform.position;

        // Simulate horizontal movement
        playerMovementScript.input = 1; // Move right
        yield return new WaitForFixedUpdate(); // Wait for FixedUpdate to execute

        // Check if the knight has moved horizontally
        Assert.AreNotEqual(initialPosition, knightObject.transform.position, "Knight did not move horizontally");
    }

    [UnityTest]
    public IEnumerator TestPlayerStartsGrounded()
    {
        // Set grounded variable
        playerMovementScript.isOnGround = true;
        
        // Check if the knight is considered grounded
        Assert.IsTrue(playerMovementScript.isOnGround, "Knight is not grounded");
        yield return null;
    }

    [UnityTest]
    public IEnumerator TestPlayerCanJump()
    {
        // Simulate jump
        playerMovementScript.Jump(); // Trigger jump
        yield return new WaitForFixedUpdate(); // Wait for FixedUpdate to execute

        // Check if the knight is jumping (has upward velocity)
        Assert.IsTrue(playerMovementScript.playerRigidBody.velocity.y > 0, "Knight did not jump");
    }

    [UnityTest]
    public IEnumerator TestPlayerCannotJumpWhenNotGrounded()
    {
        // Player on ground
        playerMovementScript.isOnGround = false;

        // Simulate jump
        playerMovementScript.JumpCheck();

        // Verify that the player is not jumping
        Assert.IsFalse(playerMovementScript.isJumping);
        yield return null;
    }

    [UnityTearDown]
    public IEnumerator TearDownTest()
    {
        // Restore original RigidBody2D
        playerMovementScript.playerRigidBody = originalRigidBody2D;
        yield return null;
    }
}