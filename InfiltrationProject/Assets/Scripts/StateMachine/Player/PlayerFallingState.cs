using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallingState : PlayerBaseState
{
    private readonly int FallHash = Animator.StringToHash("Falling");
    private const float CrossFadeDuration = 0.1f;
    private Vector3 momentum;
    public PlayerFallingState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        // momentum = stateMachine.rb.velocity;
        // momentum.y = 0;
        stateMachine.Animator.CrossFadeInFixedTime(FallHash, CrossFadeDuration);
    }

    public override void Tick(float deltaTime)
    {
        Move(momentum, deltaTime);
    }

    public override void PhysicsTick(float fixedDeltaTime)
    {
    }
    public override void Exit()
    {
    }

}
