//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class RadialTrigger : MonoBehaviour
{
    public Transform objectTransform;

    [Range(0f, 10f)] public float radius = 1f;

    #if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Vector2 origin = transform.position;
        Vector2 objectPosition = objectTransform.position;

        Vector2 displacementVector = objectPosition - origin;
        
        float distanceSquared = displacementVector.sqrMagnitude;
        float radiusSquared = radius * radius;
        
        if (distanceSquared < radiusSquared)
        {
            Handles.color = Color.green;
        }
        else
        {
            Handles.color = Color.red;
        }
        
        Handles.DrawWireDisc(origin, Vector3.forward, radius );
    }
    #endif
}
