using System.Collections.Generic;
using UnityEngine;

public class CharacterGroupExecutor : MonoBehaviour
{
    public List<CharacterMover> activeCharacters = new();

    public IEnumerator RunCommands(List<CommandSO> commands)
    {
        foreach (var command in commands)
        {
            foreach (var character in activeCharacters)
            {
                command.Execute(character);
            }

            float delay = command.repeatCount * activeCharacters[0].MoveDuration;
            yield return new WaitForSeconds(delay);
        }
    }
}
