using UnityEngine;
using LootLocker.Requests;

public class GameManager : MonoBehaviour
{
    [SerializeField] private LeaderBoardReading leaderBoardReading;

    void Awake()
    {
        leaderBoardReading = GameObject.FindGameObjectWithTag("LeaderBoard").GetComponent<LeaderBoardReading>();
        LoadLootLockerContent();
    }

    private void LoadLootLockerContent()
    {
        LootLockerSDKManager.StartGuestSession((response) =>
        {
            if (response.success)
            {
                Debug.Log("successfully started LootLocker session");
            }
            else
            {
                Debug.Log("error starting LootLocker session");
            }
        });
    }
}