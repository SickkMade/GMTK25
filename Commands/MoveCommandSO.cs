using UnityEngine;

[CreateAssetMenu(menuName = "Commands/MoveCommand")]
public class MoveCommandSO : CommandSO
{
    public Vector2Int direction;

    public override void Execute(CharacterMover character)
    {
        for (int i = 0; i < repeatCount; i++)
        {
            character.Move(direction);
        }
    }
}
