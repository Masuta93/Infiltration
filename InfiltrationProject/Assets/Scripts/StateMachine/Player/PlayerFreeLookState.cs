using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerFreeLookState : PlayerBaseState
{
    private readonly int FreeHash = Animator.StringToHash("FreeLookBlendTree");
    private const float CrossFadeDuration = 0.1f;
    public PlayerFreeLookState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }
    public override void Enter()
    {
        stateMachine.Animator.CrossFadeInFixedTime(FreeHash, CrossFadeDuration);
        stateMachine.InputsReader.JumpEvent += OnJump;
        stateMachine.InputsReader.SprintEvent += OnSprint;
    }
    public override void Tick(float deltaTime)
    {
        stateMachine.FloorDetector.AverageHeight();
        isGrounded();
        if (stateMachine.isGrounded == false)
        {
            stateMachine.SwitchState(new PlayerFallingState(stateMachine));
        }
    }
    public override void PhysicsTick(float fixedDeltatime)
    {
        StickToGround();
        Move(stateMachine.WalkSpeed, fixedDeltatime, 0.5f);
    }
    public override void Exit()
    {
        stateMachine.InputsReader.JumpEvent -= OnJump;
        stateMachine.InputsReader.SprintEvent -= OnSprint;
    }

}
