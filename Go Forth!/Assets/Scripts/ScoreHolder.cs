using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHolder : MonoBehaviour
{
    public TMP_Text scoreUI_Text;
    public int scoreNum = 0;


    public void changeScore(int addedScore)
    {
        scoreNum += addedScore;
        scoreUI_Text.text = scoreNum.ToString();
    }
}
