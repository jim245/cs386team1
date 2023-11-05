using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHolder : MonoBehaviour
{
    // TMP_Text scoreUI_Text;
    public int scoreNum = 0;
    //scoreUI_Text.text = scoreNum.ToString();

    void Start()
    {
        //scoreUI_Text.text = scoreNum.ToString();
    }

    public void changeScore(float time)
    {
        scoreNum += (int)((time*time)/5);
        //scoreUI_Text.text = scoreNum.ToString();
    }
}
