using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreHolder : MonoBehaviour
{

    public int scoreNum = 0;
    public Text scoreText;

    public void changeScore(float time)
    {
        scoreNum += (int)((time*time)/5);
        scoreText.text = scoreNum.ToString();
    }
}
