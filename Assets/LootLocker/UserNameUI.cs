using UnityEngine;
using TMPro;

public class UserNameUI : MonoBehaviour
{
    [SerializeField] private TMP_InputField nickField;
    [SerializeField] private int nickLettersLimit = 12;
    private string nick = "";

    private void Start()
    {
        nickField.characterLimit = nickLettersLimit;
    }

    public string GetNick()
    {
        return nick;
    }

    public void SetNick()
    {
        if(nickField.text != null)
        {
            nick = nickField.text;
            Debug.Log(nick);
        }
    }
}