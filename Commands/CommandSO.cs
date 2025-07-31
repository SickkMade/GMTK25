using UnityEngine;

public abstract class CommandSO : ScriptableObject, ICommand
{
    public int repeatCount = 1;
    public abstract void Execute(CharacterMover character);
}
