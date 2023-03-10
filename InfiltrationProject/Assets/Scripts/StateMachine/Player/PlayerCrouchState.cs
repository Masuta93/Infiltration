using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrouchState : PlayerBaseState
{
    private readonly int CrouchHash = Animator.StringToHash("CrouchBlendTree");
    private const float CrossFadeDuration = 0.1f;
    public PlayerCrouchState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.collider1.enabled = false;
        stateMachine.collider2.enabled = true;
        stateMachine.Animator.CrossFadeInFixedTime(CrouchHash, CrossFadeDuration);
        stateMachine.InputsReader.JumpEvent += OnJump;
        stateMachine.InputsReader.StopCrouchEvent += OnStopCrouch;
    }
    public override void Tick(float deltaTime)
    {

    }
    public override void PhysicsTick(float fixedDeltaTime)
    {
        stateMachine.FloorDetector.AverageHeight();
        if (stateMachine.isGrounded == false)
        {
            stateMachine.SwitchState(new PlayerFallingState(stateMachine));
        }
        Grounded();
        StickToGround();
        Move(stateMachine.CrouchSpeed, fixedDeltaTime, 1);
    }
    public override void Exit()
    {
        stateMachine.collider1.enabled = true;
        stateMachine.collider2.enabled = false;
        stateMachine.InputsReader.JumpEvent -= OnJump;
        stateMachine.InputsReader.StopCrouchEvent -= OnStopCrouch;
    }
}
