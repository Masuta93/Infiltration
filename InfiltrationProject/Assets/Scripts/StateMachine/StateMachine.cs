using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{
    private State currentState;

    public void SwitchState(State newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState?.Enter();
    }

    private void Update()
    {
        currentState?.Tick(Time.deltaTime);
    }
    private void FixedUpdate()
    {
        currentState?.PhysicsTick(Time.fixedDeltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireCube(new Vector3 (transform.position.x, transform.position.y-0.7f, transform.position.z), new Vector3(.2f, 1.5f/2, .2f));
    }
}
