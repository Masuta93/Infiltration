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
        stateMachine.InputsReader.CrouchEvent += OnCrouch;
        stateMachine.InputsReader.StopSprintEvent += OnStopSprint;
    }
    public override void Tick(float deltaTime)
    {
        stateMachine.FloorDetector.AverageHeight();
        Grounded();
        if (stateMachine.isGrounded == false)
        {
            stateMachine.SwitchState(new PlayerFallingState(stateMachine));
        }
    }
    public override void PhysicsTick(float fixedDeltaTime)
    {
        Move(stateMachine.RunSpeed, fixedDeltaTime, 1);
        StickToGround();
    }
    public override void Exit()
    {
        stateMachine.InputsReader.JumpEvent -= OnJump;
        stateMachine.InputsReader.CrouchEvent -= OnCrouch;
        stateMachine.InputsReader.StopSprintEvent -= OnStopSprint;
    }
}
