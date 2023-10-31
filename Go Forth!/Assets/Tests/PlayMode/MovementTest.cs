using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class JumpTest
{
    GameObject playerObject;
    PlayerMovement playerMovementScript;

    [SetUp]
    public void Setup()
    {
        // Loads player from scene
        GameObject playerObject = new GameObject();
        playerObject.AddComponent<PlayerMovement>();

        PlayerMovement playerMovementScript = playerObject.GetComponent<PlayerMovement>();
    }

    [UnityTest]
    public IEnumerator PlayerCanJumpWhenGrounded()
    {
        // Player on ground
        playerMovementScript.isOnGround = true;

        // Player jumps
        playerMovementScript.Update();
        playerMovementScript.FixedUpdate();

        // Verify that the player is jumping
        Assert.IsTrue(playerMovementScript.isJumping);

        yield return null;
    }

    [UnityTest]
    public IEnumerator PlayerStopsJumpingWhenJumpButtonReleased()
    {
        // Simulate the player jumping
        playerMovementScript.isJumping = true;

        // Simulate releasing the jump button
        playerMovementScript.Update();
        playerMovementScript.FixedUpdate();

        // Verify that the player stops jumping
        Assert.IsFalse(playerMovementScript.isJumping);

        yield return null;
    }

    // Simulate the jump button press
    private IEnumerator SimulateJump()
    {
        // Simulate pressing the jump button
        playerMovementScript.isOnGround = true; // Ensure the player is grounded
        playerMovementScript.Update(); // Simulate the Update method

        // Yield a frame to mimic the behavior over time
        yield return null;
    }
}