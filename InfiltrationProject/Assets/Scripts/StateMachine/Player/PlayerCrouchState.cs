using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrouchState : PlayerBaseState
{
    public PlayerCrouchState(PlayerStateMachine stateMachine) : base(stateMachine)
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
    }
    public override void Exit()
    {
        stateMachine.InputsReader.JumpEvent -= OnJump;
    }
}
