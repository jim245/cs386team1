using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using System.Numerics;

public class CheckpointTests
{
    private GameObject knightObject;
    private GameObject respawnPointObject;
    private GameObject checkpointFlagObject;
    private CheckpointScript checkpointScript;

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

        // Find the respawn point object in the scene
        respawnPointObject = GameObject.FindGameObjectWithTag("Respawn");
        Assert.IsNotNull(respawnPointObject, "Respawn point object not found in the scene");

        // Find the checkpoint flag object in the scene
        checkpointFlagObject = GameObject.FindGameObjectWithTag("Checkpoint");
        Assert.IsNotNull(checkpointFlagObject, "Checkpoint flag object not found in the scene");

        // Get the checkpoint script
        checkpointScript = checkpointFlagObject.GetComponent<CheckpointScript>();
        Assert.IsNotNull(checkpointScript, "Checkpoint script not found on the checkpoint flag object");
    }

    [UnityTest]
    public IEnumerator TestTests()
    {
        // Check if the respawn point is at the start initially
        Assert.IsTrue(true);
        yield return null;
    }

    [UnityTest]
    public IEnumerator TestRespawnPointFirstAtStart()
    {
        // Check if the respawn point is at the start initially
        Assert.IsTrue(respawnPointObject.transform.position.x == knightObject.transform.position.x, "Respawn not initially at knight start");
        yield return null;
    }

    [UnityTest]
    public IEnumerator TestCheckpointFlagChangesRespawnPoint()
    {
        // Simulate knight interacting with checkpoint flag
        knightObject.transform.position = checkpointFlagObject.transform.position;
        yield return null;

        // Check if the respawn point changed to checkpoint flag
        Assert.IsTrue(respawnPointObject.transform.position == checkpointFlagObject.transform.position, "Respawn point did not change");
        yield return null;
    }
}
