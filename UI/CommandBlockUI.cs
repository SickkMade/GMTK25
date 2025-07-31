using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CommandBlockUI : MonoBehaviour
{
    [SerializeField] private CommandSO command;
    [SerializeField] private TextMeshProUGUI repeatText;

    public void SetRepeat(int value)
    {
        command.repeatCount = value;
        repeatText.text = value.ToString();
    }
}
