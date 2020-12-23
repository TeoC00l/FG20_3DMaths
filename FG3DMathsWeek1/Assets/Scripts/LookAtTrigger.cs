//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif
public class LookAtTrigger : MonoBehaviour
{
    
    [Tooltip("0 = object will be detected at a perpendicular angle. 1 = object will only be detected head on")]
    [Range(0, 1)] public float detectionSensitivity = 1f;
    [Range(0, 10)] public float dashSize = 1f;
    
    public Transform objectTransform;

    private bool isDetected;

    #if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Vector2 objectPosition = objectTransform.position;
        Vector2 origin = transform.position;

        Vector2 displacementVector = objectPosition - origin;
        

        float dot = Vector2.Dot(objectTransform.right, displacementVector.normalized);

        if (-dot >= detectionSensitivity)
        {
            Handles.color = Color.green;
        }
        else
        {
            Handles.color = Color.red;
        }
        
        Handles.DrawDottedLine(origin, objectPosition, dashSize);
    
    }
    #endif
}
