using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Updates respawn point
            GameObject.Find("RespawnPoint").transform.position = GameObject.Find("CheckpointFlag").transform.position;
        }
    }
}
