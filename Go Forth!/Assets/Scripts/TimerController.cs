using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    bool runTimer = true;
    public float t;

    void Start () {
        startTime = Time.time;
    }

    void Update () {
        if (runTimer)
        {
            t = Time.time - startTime;

            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            timerText.text = minutes + ":" + seconds;
        }
    }

    public void stopTimer()
    {
        runTimer = false;
    }

    public void startTimer()
    {
        runTimer = true;
    }

    public float getTime()
    {
        return t;
    }
}
