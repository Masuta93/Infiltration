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
        Debug.Log(currentState);
    }
    private void FixedUpdate()
    {
        currentState?.PhysicsTick(Time.fixedDeltaTime);
    }


}
