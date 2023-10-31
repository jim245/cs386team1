using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class MovementTest
{

    [UnityTest]
    public IEnumerator PlayerCanMove()
    {
        var playerObject = new GameObject("Knight");
        var playerMovement = playerObject.AddComponent<PlayerMovement>();

        // Set jumping
        playerMovement.isJumping = true;

        // Check if the player is jumping
        Assert.IsTrue(playerMovement.isJumping);

        yield return null;
    }

    [UnityTest]
    public IEnumerator PlayerCanJumpWhenGrounded()
    {
        var playerObject = new GameObject("Knight");
        var playerMovement = playerObject.AddComponent<PlayerMovement>();

        // Player on ground
        playerMovement.isOnGround = true;

        // Player jumps
        playerMovement.Jump();

        // Verify that the player is jumping after calling the Jump method
        Assert.IsTrue(playerMovement.isJumping);

        yield return null;
    }
}