using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    private Transform checker;
    public PlayerStateMachine BoxDimension;
    private Vector3 dimension;

    private void Awake()
    {
       dimension= BoxDimension.BoxDimension;
    }
    private void Update()
    {
    }
    private void OnDrawGizmos()
        {
            Gizmos.color = Color.magenta;
            Gizmos.DrawWireCube(transform.position, dimension);
        }
}
