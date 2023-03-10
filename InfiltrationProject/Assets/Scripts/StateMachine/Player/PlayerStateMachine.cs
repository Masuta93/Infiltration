using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    [field: SerializeField] public InputsReader InputsReader { get; private set; }
    [field: SerializeField] public float JumpForce { get; private set; }
    [field: SerializeField] public float WalkSpeed { get; private set; }
    [field: SerializeField] public float RunSpeed { get; private set; }
    [field: SerializeField] public float CrouchSpeed { get; private set; }
    [field: SerializeField] public Animator Animator { get; private set; }
    [field: SerializeField] public float yPositionOffet{ get; private set; }
    [field: SerializeField] public float RotationSpeed { get; private set; }
    [field: SerializeField] public GameObject GroundChecker { get; private set; }
    [field: SerializeField] public Vector3 BoxDimension { get; private set; }
    [field: SerializeField] public LayerMask GroundMask { get; private set; }
    [field: SerializeField] public FloorDetector FloorDetector { get; private set; }
    [field: SerializeField] public bool isGrounded { get; set; }

    public Collider collider1;
    public Collider collider2;
    public Transform MainCameraTransform { get; private set; }

    public Rigidbody rb { get; private set; }
    private void Awake()
    {
        collider2.enabled = false;
        yPositionOffet = 1f;
        rb= GetComponent<Rigidbody>();
    }
    void Start()
    {
        MainCameraTransform = Camera.main.transform;
        SwitchState(new PlayerFreeLookState(this));
    }
}
