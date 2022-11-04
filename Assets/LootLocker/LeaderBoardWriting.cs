using UnityEngine;
using LootLocker.Requests;

public class LeaderBoardWriting : MonoBehaviour
{
    //TODO: Zrobi� tak by nie da�o si� zapisa� jak jest wynik mniejszy od najmniejszego
    //TODO: (tak by na tablicy mog�o by� 7-8 nick�w)
    private ScoreManager scoreManager;
    private UserNameUI userNameUI;

    private void Awake()
    {
        scoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
        userNameUI = GameObject.FindGameObjectWithTag("UserNameUI").GetComponent<UserNameUI>();
    }

    public void SubmitScore()
    {
        if(userNameUI.GetNick() != "")
        {
            string leaderboardName = "score_board";

            LootLockerSDKManager.SubmitScore(userNameUI.GetNick(), scoreManager.GetScore(), leaderboardName, (response) =>
            {
                if (response.success)
                {
                    Debug.Log("Successful");
                }
                else
                {
                    Debug.Log("failed: " + response.Error);
                }
            });
        }
    }
}
