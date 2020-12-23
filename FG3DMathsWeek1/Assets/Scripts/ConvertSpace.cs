//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

public class ConvertSpace : MonoBehaviour
{
    public Vector2 localSpacePoint = default;

    public void WorldToLocal()
    {
        
    }

    public Vector2 LocalToWorld(Vector2 localPosition, Vector2 right, Vector2 up)
    {
        Vector2 worldOffset = right * localPosition.x + up * localPosition.y;

        return (Vector2) transform.position + worldOffset;
    }

    private void OnDrawGizmos()
    {
        Vector2 position = transform.position;
        Vector2 right = transform.right;
        Vector2 up = transform.up;

        DrawVectors(position, right, up);
        DrawVectors(Vector2.zero, Vector2.right, Vector2.up);
        
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(position, 0.2f);
        
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(LocalToWorld(localSpacePoint, transform.right, transform.up), 0.2f);

    }

    private void DrawVectors(Vector2 position, Vector2 right, Vector2 up)
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(position, right);
        Gizmos.color = Color.green;
        Gizmos.DrawRay(position, up);

    }
}
