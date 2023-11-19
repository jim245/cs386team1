using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public int score = 0;
    private Text uiText;

    private void Start()
    {
        uiText = GetComponent<Text>();
    }

    void Update()
    {
        uiText.text = score.ToString("#,0");
    }

    public void AddToScore()
    {
        score += 1;
        uiText.text = score.ToString();
    }

    
}
