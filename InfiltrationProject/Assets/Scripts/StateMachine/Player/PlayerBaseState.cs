using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBaseState : State
{
    protected PlayerStateMachine stateMachine;

    public PlayerBaseState(PlayerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }
    protected void Move(float speed, float deltaTime, float state)
    {
        Vector3 movement = CalculateMovement();
        if (movement.magnitude > 0)
        {
            stateMachine.rb.velocity = new Vector3 (movement.normalized.x * speed, stateMachine.rb.velocity.y, movement.normalized.z * speed);

            Vector3 lookPos = stateMachine.MainCameraTransform.forward;
            lookPos.y = 0;
            Quaternion rotation = Quaternion.LookRotation(lookPos);
            rotation = Quaternion.RotateTowards(stateMachine.rb.rotation, rotation, stateMachine.RotationSpeed);
            stateMachine.rb.MoveRotation(rotation);

            stateMachine.Animator.SetFloat("FreeLookSpeed", state, 0.1f, deltaTime);
        }
        else
        {
            stateMachine.rb.velocity = new Vector3 (0, stateMachine.rb.velocity.y,0);
            stateMachine.Animator.SetFloat("FreeLookSpeed", 0, 0.1f, deltaTime);
        }
    }

    protected void Move(Vector3 momentum, float deltaTime)
    {
        Vector3 movement = CalculateMovement();
        if (movement.magnitude > 0)
        {
            stateMachine.rb.velocity = momentum;
            stateMachine.transform.rotation = Quaternion.LookRotation(movement);
            stateMachine.Animator.SetFloat("FreeLookSpeed", 0.66f, 0.1f, deltaTime);
        }
        else
        {
            stateMachine.rb.velocity = new Vector3(0, stateMachine.rb.velocity.y, 0);
            stateMachine.Animator.SetFloat("FreeLookSpeed", 0, 0.1f, deltaTime);
        }
    }



    private Vector3 CalculateMovement()
    {
        Vector3 forward = stateMachine.MainCameraTransform.forward;
        Vector3 right = stateMachine.MainCameraTransform.right;


        forward.Normalize();
        right.Normalize();

        return forward * stateMachine.InputsReader.MovementValue.y + right * stateMachine.InputsReader.MovementValue.x;
    }


    public void OnJump()
    {
        stateMachine.SwitchState(new PlayerJumpingState(stateMachine));
    }
    public void OnSprint()
    {
        stateMachine.SwitchState(new PlayerRunningState(stateMachine));
    }
}
