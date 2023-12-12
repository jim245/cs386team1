using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerColliderHandler : MonoBehaviour
{
    ScoreHolder scoreTemp;
    TimerController timeTemp;
    int currentLevel = 1;
    void Start()
    {
        scoreTemp = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreHolder>();
        timeTemp = GameObject.FindGameObjectWithTag("Timer").GetComponent<TimerController>();
        Debug.Log("Started");
    }

    
}
