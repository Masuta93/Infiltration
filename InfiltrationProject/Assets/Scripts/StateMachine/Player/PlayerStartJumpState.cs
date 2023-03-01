using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartJumpState : PlayerBaseState
{
    private readonly int JumpHash = Animator.StringToHash("Jump");
    private const float CrossFadeDuration = 0.1f;
    public PlayerStartJumpState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.Animator.CrossFadeInFixedTime(JumpHash, CrossFadeDuration);
        stateMachine.rb.AddForce(Vector3.up * 250, ForceMode.Impulse);
    }

    public override void Tick(float deltaTime)
    {
        
    }
    public override void PhysicsTick(float fixedDeltaTime)
    {
        Grounded();
        if (!stateMachine.isGrounded)
        {
            stateMachine.SwitchState(new PlayerJumpingState(stateMachine));
        }
    }

    public override void Exit()
    {
    }

}
