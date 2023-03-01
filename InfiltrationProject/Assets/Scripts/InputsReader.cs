using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputsReader : MonoBehaviour, Controls.IPlayerActions
{
    public Vector2 MovementValue { get; private set; }
    public event Action StopSprintEvent;
    public event Action SprintEvent;
    public event Action CrouchEvent;
    public event Action StopCrouchEvent;
    public event Action JumpEvent;

    private Controls controls;

    private void Start()
    {
        controls = new Controls();
        controls.Player.SetCallbacks(this);
        controls.Player.Enable();
    }

    private void OnDestroy()
    {
        controls.Player.Disable();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (!context.performed) { return; }
        JumpEvent?.Invoke();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        MovementValue = context.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
    }

    public void OnRun(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            SprintEvent?.Invoke();
        }
        else if (context.canceled)
        {
            StopSprintEvent?.Invoke();
        }
    }

    public void OnCrouch(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            CrouchEvent?.Invoke();
        }
        else if (context.canceled)
        {
            StopCrouchEvent?.Invoke();
        }
    }
}
