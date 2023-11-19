using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckIfFallen : MonoBehaviour
{
    public static float bottomY = -20f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < bottomY)
        {
            // Respawn player
            GameObject.Find("Knight").transform.position = GameObject.Find("RespawnPoint").transform.position;
        }
    }
}
