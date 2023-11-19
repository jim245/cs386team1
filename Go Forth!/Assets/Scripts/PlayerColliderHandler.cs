using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColliderHandler : MonoBehaviour
{
    ScoreHolder scoreTemp;
    TimerController timeTemp;

    void Start()
    {
        scoreTemp = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreHolder>();
        timeTemp = GameObject.FindGameObjectWithTag("Timer").GetComponent<TimerController>();
        Debug.Log("Started");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Collider2D>().name == "Flag")
        {
            timeTemp.stopTimer();
            scoreTemp.changeScore(timeTemp.getTime());
            Debug.Log("Collided With Flagpole");
        }
    }
}
