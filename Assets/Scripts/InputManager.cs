using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class InputManager : MonoBehaviour {

    private PlayerInputActions playerInputActions;
    private PlayerLocomotion playerLocomotion;
    private AnimatorManager animatorManager;

    [SerializeField] private Vector2 movementInput;
    [SerializeField] private Vector2 cameraInput;

    public float cameraInputX;
    public float cameraInputY;

    public float moveAmount;
    public float verticalInput;
    public float horizontalInput;

    [SerializeField] private bool sprint_input;
    [SerializeField] private bool jump_input;

    private void Awake() {
        animatorManager = FindObjectOfType<AnimatorManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
    }

    private void OnEnable() {
        if (playerInputActions == null) {
            playerInputActions = new PlayerInputActions();

            playerInputActions.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
            playerInputActions.PlayerMovement.Camera.performed += i => cameraInput = i.ReadValue<Vector2>();

            playerInputActions.PlayerActions.Sprint.performed += i => sprint_input = true;
            playerInputActions.PlayerActions.Sprint.canceled += i => sprint_input = false;
            playerInputActions.PlayerActions.Jump.performed += i => jump_input = true;
        }

        playerInputActions.Enable();
    }

    private void OnDisable() {
        playerInputActions.Disable();
    }

    public void HandleAllInputs() {
        HandleMovementInput();
        HandleSprintingInput();
        HandleJumpingInput();
    }

    private void HandleMovementInput() {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;

        cameraInputY = cameraInput.y;
        cameraInputX = cameraInput.x;

        moveAmount = Mathf.Clamp01(Mathf.Abs(horizontalInput) + Mathf.Abs(verticalInput));
        animatorManager.UpdateAnimatorValues(0, moveAmount, playerLocomotion.isSprinting);
    }

    private void HandleSprintingInput() {
        if (sprint_input && moveAmount > 0.5f) {
            playerLocomotion.isSprinting = true;
        } else {
            playerLocomotion.isSprinting = false;
        }
    }

    private void HandleJumpingInput() {
        if (jump_input) {
            jump_input = false;
            playerLocomotion.HandleJumping();
        }
    }

    public bool RunningTowardsCamera() {
        return movementInput.y == -1;
    }

    public bool IsSprinting() {
        return sprint_input;
    }
}*/