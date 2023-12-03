using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Dan.Main;

public class Leaderboard : MonoBehaviour
{
    [SerializeField]
    private List<TextMeshProUGUI> names;
    [SerializeField]
    private List<TextMeshProUGUI> scores;

    private string lbKey = "374799258265a00445187323184e59a80a798ed42de59897069b3f8932dc52d3";

    public void GetLeaderboard()
    { 
       LeaderboardCreator.GetLeaderboard(lbKey, ((msg) => {

           for (int i = 0; i < names.Count; i++) {
               names[i].text = msg[i].Username;
               scores[i].text = msg[i].Score.ToString();
           }
       }));
    }

    public void SetLeaderboardEntry(string username, int score) 
    {
        LeaderboardCreator.UploadNewEntry(lbKey, username, score, ((msg) => {
            //if(name.Length > 9) 
            //{
            //    name.Substring(0, 9);
            //}
            GetLeaderboard();
        }));
    }
}
