using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class PlayerManager : MonoBehaviour {

    private Animator animator;
    private InputManager inputManager;
    CameraManager cameraManager;
    private PlayerLocomotion playerLocomotion;

    public bool isInteracting;

    private void Awake() {
        animator = FindObjectOfType<Animator>();
        inputManager = GetComponent<InputManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
        cameraManager = FindObjectOfType<CameraManager>();
    }

    private void Update() {
        inputManager.HandleAllInputs();
    }

    private void FixedUpdate() {
        playerLocomotion.HandleAllMovement();
    }

    private void LateUpdate() {
        cameraManager.HandleAllCameraMovement();

        isInteracting = animator.GetBool("isInteracting");
        playerLocomotion.isJumping = animator.GetBool("isJumping");
        animator.SetBool("isGrounded", playerLocomotion.isGrounded);
    }
}*/