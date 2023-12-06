using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;

public class EndFlagScript : MonoBehaviour
{
    public string nextLevel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Go to next level
            SceneManager.LoadScene(nextLevel);  // Loads next level
        }
    }
}
