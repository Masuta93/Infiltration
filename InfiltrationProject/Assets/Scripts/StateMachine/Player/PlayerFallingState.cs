using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallingState : PlayerBaseState
{
    private readonly int FallHash = Animator.StringToHash("Falling");
    private const float CrossFadeDuration = 0.1f;
    public PlayerFallingState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.Animator.CrossFadeInFixedTime(FallHash, CrossFadeDuration);
    }

    public override void Tick(float deltaTime)
    {
        if(stateMachine.isGrounded == true)
        {
            stateMachine.SwitchState(new PlayerFreeLookState(stateMachine));
        }
        MoveJump(5);
    }

    public override void PhysicsTick(float fixedDeltaTime)
    {
        Grounded();
    }
    public override void Exit()
    {
    }

}
