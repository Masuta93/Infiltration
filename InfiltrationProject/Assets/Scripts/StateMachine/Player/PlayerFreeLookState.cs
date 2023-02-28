using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFreeLookState : PlayerBaseState
{
    public PlayerFreeLookState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.InputsReader.JumpEvent += OnJump;
        stateMachine.InputsReader.SprintEvent += OnSprint;
    }
    public override void Tick(float deltaTime)
    {
    }
    public override void PhysicsTick(float fixedDeltatime)
    {
        Move(stateMachine.WalkSpeed, fixedDeltatime,0.66f);
    }
    public override void Exit()
    {
        stateMachine.InputsReader.JumpEvent -= OnJump;
        stateMachine.InputsReader.SprintEvent -= OnSprint;
    }
    public void Jump(float jumpForce)
    {
    }
}
