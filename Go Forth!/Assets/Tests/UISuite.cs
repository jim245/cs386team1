using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class NewGameTest : InputTestFixture
    {
        // Create setup method
        public override void Setup()
        {
            base.Setup();

            // Load the title screen
            SceneManager.LoadScene("TitleScreen");
        }

        [UnityTest]
        public IEnumerator TestNewGame()
        {
            // Find the new game button
            GameObject newGameButton = GameObject.Find("Canvas/NewGame");

            // Get the scene name
            string sceneName = SceneManager.GetActiveScene().name;

            // Test if the scene name is the title screen
            Assert.That(sceneName, Is.EqualTo("TitleScreen"));

            // Click the new game button
            ExecuteEvents.Execute(newGameButton, new PointerEventData(EventSystem.current), ExecuteEvents.pointerClickHandler);

            // Wait for 2 seconds
            yield return new WaitForSeconds(2f);

            // Get the scene name
            sceneName = SceneManager.GetActiveScene().name;

            // Test is the scene name is the first level
            Assert.That(sceneName, Is.EqualTo("Level1"));
        }
    }
}