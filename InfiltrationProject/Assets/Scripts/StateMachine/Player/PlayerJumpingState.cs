using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpingState : PlayerBaseState
{
    private readonly int JumpHash = Animator.StringToHash("Jump");
    private const float CrossFadeDuration = 0.1f;
    public PlayerJumpingState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.Animator.CrossFadeInFixedTime(JumpHash, CrossFadeDuration);
        stateMachine.rb.AddForce(Vector3.up * 250, ForceMode.Impulse);
    }

    public override void Tick(float deltaTime)
    {
        isGrounded();
        if (!stateMachine.isGrounded && stateMachine.rb.velocity.y < 1)
        {
            stateMachine.SwitchState(new PlayerFallingState(stateMachine));
            return;
        }
        MoveJump(5);
    }
    public override void PhysicsTick(float fixedDeltaTime)
    {

    }

    public override void Exit()
    {
    }
}
