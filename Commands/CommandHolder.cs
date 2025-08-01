
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CommandHolder : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI repeatTMP;
    [SerializeField] private Image holderIcon;

    public void SetHolder(CommandSO command)
    {
        repeatTMP.text = command.repeatCount.ToString();
        holderIcon.sprite = command.commandIcon;
    }
}
