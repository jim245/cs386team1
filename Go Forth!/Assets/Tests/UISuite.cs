using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class NewGameTest : InputTestFixture
    {
        // Create mouse object
        Mouse mouse;

        // Create setup method
        public override void Setup()
        {
            base.Setup();

            // Load the title screen
            SceneManager.LoadScene("TitleScreen");

            // Add the mouse object to the input system
            mouse = InputSystem.AddDevice<Mouse>();
        }

        public void ClickUI(GameObject element)
        {
            // Create and set the camera object
            Camera camera = GameObject.Find("Main Camera").GetComponent<Camera>();

            // Create and set the screen position
            Vector3 screenPos = camera.WorldToScreenPoint(element.transform.position);

            // Move the mouse to the screen position
            Set(mouse.position, screenPos);

            // Click the mouse
            Click(mouse.leftButton);
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
            ClickUI(newGameButton);

            // Wait for 2 seconds
            yield return new WaitForSeconds(2f);

            // Get the scene name
            sceneName = SceneManager.GetActiveScene().name;

            // Test is the scene name is the first level
            Assert.That(sceneName, Is.EqualTo("Level1"));
        }
    }
}