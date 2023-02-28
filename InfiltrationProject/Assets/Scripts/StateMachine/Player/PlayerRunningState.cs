using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunningState : PlayerBaseState
{
    public PlayerRunningState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.InputsReader.JumpEvent += OnJump;
    }
    public override void Tick(float deltaTime)
    {
    }
    public override void PhysicsTick(float fixedDeltaTime)
    {
        Move(stateMachine.RunSpeed, fixedDeltaTime,1);
        Debug.Log("blabl");
    }
    public override void Exit()
    {
        stateMachine.InputsReader.JumpEvent -= OnJump;
    }
}
