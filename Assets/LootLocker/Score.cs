using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI text;
    private string displayedScore = "------";

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        DisplayScore(displayedScore);
    }

    public void DisplayScore(int score)
    {
        displayedScore = score.ToString();
        text.text = displayedScore;
    }

    public void DisplayScore(string score)
    {
        displayedScore = score;
        text.text = displayedScore;
    }
}
