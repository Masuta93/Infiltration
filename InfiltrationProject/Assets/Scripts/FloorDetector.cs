using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDetector : MonoBehaviour
{
    [SerializeField] private Transform[] rayOrigins;
    [SerializeField] private float rayLength = 1.5f;
    [SerializeField] private LayerMask GroundMask;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        foreach (Transform o in rayOrigins)
        {
            Gizmos.DrawRay(o.position, Vector3.down * rayLength);
        }
    }
    public Vector3 AverageHeight()
    {
        int hitCount = 0;
        Vector3 combinedPosition = Vector3.zero;
        RaycastHit hit;
        foreach(Transform o in rayOrigins)
        {
            if (Physics.Raycast(o.position,Vector3.down, out hit,rayLength, GroundMask))
            {
                hitCount++;
                combinedPosition += hit.point;
            }
        }
        Vector3 averagePosition = Vector3.zero;
        if (hitCount > 0)
        {
            averagePosition = combinedPosition / hitCount; 
        }

        return averagePosition;
    }
    void Start()
    {

    }

    void Update()
    {
        AverageHeight();
    }
}
