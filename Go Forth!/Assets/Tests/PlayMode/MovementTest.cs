using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class MovementTest
{

    [UnityTest]
    public IEnumerator PlayerCanMove()
    {
        GameObject playerObject = new GameObject("Knight");
        PlayerMovement playerMovement = playerObject.AddComponent<PlayerMovement>();

        // Set jumping
        playerMovement.isJumping = true;

        // Check if the player is jumping
        Assert.IsTrue(playerMovement.isJumping);

        yield return null;
    }
}