using UnityEngine;
using LootLocker.Requests;

public class LeaderBoardWriting : MonoBehaviour
{
    //TODO: Zrobiæ tak by nie da³o siê zapisaæ jak jest wynik mniejszy od najmniejszego
    //TODO: (tak by na tablicy mog³o byæ 7-8 nicków)
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
