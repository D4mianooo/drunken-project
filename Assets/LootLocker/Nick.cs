using UnityEngine;
using TMPro;

public class Nick : MonoBehaviour
{
    private TextMeshProUGUI text;
    private string displayedNick = "------";

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        DisplayNick(displayedNick);
    }

    public void DisplayNick(string nick)
    {
        displayedNick = nick;
        text.text = displayedNick;
    }
}
