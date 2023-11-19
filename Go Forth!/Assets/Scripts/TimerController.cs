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
    public float timeVal;

    void Start () {
        startTime = Time.time;
    }

    void Update () {
        if (runTimer)
        {
            timeVal = Time.time - startTime;

            string minutes = ((int)timeVal / 60).ToString();
            string seconds = (timeVal % 60).ToString("f2");

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
        return timeVal;
    }
}
