using System.Collections.Generic;
using UnityEngine;

public class CommandSequenceUI : MonoBehaviour
{
    [SerializeField] private List<CommandSO> commandSequence = new();
    [SerializeField] private CharacterGroupExecutor executor;

    public void RunCommands()
    {
        StartCoroutine(executor.RunCommands(commandSequence));
    }
}
