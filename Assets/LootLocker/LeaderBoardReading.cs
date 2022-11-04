using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LootLocker.Requests;
using System;

public class LeaderBoardReading : MonoBehaviour
{
    //TODO: Zaczytywanie nicku gracza i jego scora po czym umieszczanie go w odpowiednich polach textowych.
    [SerializeField] private Score[] scores;
    [SerializeField] private Nick[] nicks;

    private void Awake()
    {
        scores = GetComponentsInChildren<Score>();
        nicks = GetComponentsInChildren<Nick>();
        DisableContentObjectAfterDataLoading();
    }

    private void DisableContentObjectAfterDataLoading()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }

    public void LoadLeaderBoardData()
    {
        string leaderboardName = "score_board";
        int count = 7;
        int after = 0;

        LootLockerSDKManager.GetScoreList(leaderboardName, count, after, (response) =>
        {
            if (response.success)
            {
                Debug.Log("Score Successful");

                LootLockerLeaderboardMember[] items = response.items;
                for (int i = 0; i < count; i++)
                {
                    nicks[i].DisplayNick(items[i].member_id);
                    scores[i].DisplayScore(items[i].score);
                }
            }
            else
            {
                Debug.Log("failed: " + response.Error);
            }
        });
    }
}
