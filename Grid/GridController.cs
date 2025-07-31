using UnityEngine;

public class GridController : MonoBehaviour
{
    public Vector3 origin = Vector3.zero;
    public float cellSize = 1f;

    public Vector3 GridToWorld(Vector2Int gridPosition)
    {
        return origin + new Vector3(gridPosition.x * cellSize, 0, gridPosition.y * cellSize);
    }
}
