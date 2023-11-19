using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHolder : MonoBehaviour
{
    // TMP_Text scoreUI_Text;
    public int scoreNum = 0;
    public Text scoreText;

    public void changeScore(float time)
    {
        scoreNum += (int)((time*time)/5);
        scoreText.text = scoreNum.ToString();
    }
}
