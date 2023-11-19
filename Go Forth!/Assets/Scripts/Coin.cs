using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    public float floatStrength = 0.5f; // Adjust the strength of floating
    public float rotationSpeed = 100f; // Adjust the speed of rotation
    public GameObject scoreDisplay; // Reference to the score display object

    private bool collected = false; // Flag to track if the coin is collected

    private void Update()
    {
        // Make the coin float up and down
        transform.position = new Vector3(transform.position.x,
                                         Mathf.Sin(Time.time) * floatStrength,
                                         transform.position.z);

        // Make the coin spin around
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);

        CollectCoin();
    }

    void CollectCoin()
    {
        FindObjectOfType<ScoreUpdate>().AddToScore();
        Destroy(gameObject);
    }
}
