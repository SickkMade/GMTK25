using System.Collections;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    [SerializeField] private Vector2Int gridPosition;
    [SerializeField] private float moveDuration = 0.2f;

    public float MoveDuration {
        get { return moveDuration; }
    }

    private GridController gridController;
    public void Move(Vector2Int direction)
    {
        gridPosition += direction;
        Vector3 worldPosition = gridController.GridToWorld(gridPosition);
        StartCoroutine(MoveTo(worldPosition));

    }

    private IEnumerator MoveTo(Vector3 destination)
    {
        Vector3 start = transform.position;
        float elapsed = 0f;

        while (elapsed < moveDuration)
        {
            transform.position = Vector3.Lerp(start, destination, elapsed / moveDuration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.position = destination;
    }
    public void Break(Vector2Int direction)
    {

    }

    public void SetGrid(GridController controller)
    {
        gridController = controller;
    }
}
