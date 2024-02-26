using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class PlayerLocomotion : MonoBehaviour {

    private PlayerManager playerManager;
    private AnimatorManager animatorManager;
    private InputManager inputManager;

    private Vector3 moveDirection;
    private Transform cameraObject;
    private Rigidbody playerRigidbody;

    [Header("Falling")]
    [SerializeField] private float inAirTimer;
    [SerializeField] private float leapingVelocity;
    [SerializeField] private float fallingVelocity;
    [SerializeField] private float rayCastHeightOffset = 0.5f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float maxDistance = 1;

    [Header("Movement Flags")]
    public bool isSprinting;
    public bool isGrounded;
    public bool isJumping;

    [Header("Movement Speeds")]
    [SerializeField] private float walkingSpeed = 1.5f;
    [SerializeField] private float runningSpeed = 5;
    [SerializeField] private float sprintingSpeed = 7;
    [SerializeField] private float rotationSpeed = 15;

    [Header("Jump Speeds")]
    [SerializeField] private float jumpHeight = 3;
    [SerializeField] private float gravityIntensity = -15;

    private void Awake() {
        inputManager = GetComponent<InputManager>();
        animatorManager = FindObjectOfType<AnimatorManager>();
        playerRigidbody = GetComponent<Rigidbody>();
        playerManager = GetComponent<PlayerManager>();
        cameraObject = Camera.main.transform;
    }


    public void HandleAllMovement() {

        HandleFallingAndLanding();

        if (playerManager.isInteracting) 
            return;
        
        HandleMovement();
        HandleRotation();
    }

    private void HandleMovement() {
        if (isJumping || !isGrounded)
            return;

        moveDirection = cameraObject.forward * inputManager.verticalInput;
        moveDirection = moveDirection + cameraObject.right * inputManager.horizontalInput;
        moveDirection.Normalize();
        moveDirection.y = 0;

        if (isSprinting) {

            moveDirection = moveDirection * sprintingSpeed;
        } else {

            if (inputManager.moveAmount >= 0.5f) {
                moveDirection = moveDirection * runningSpeed;
            }
            else {
                moveDirection = moveDirection * walkingSpeed;
            }
        }



        Vector3 movementVelocity = moveDirection;
        playerRigidbody.velocity = movementVelocity;
    }

    private void HandleRotation() {
        if (isJumping || !isGrounded)
            return;

        Vector3 targetDirection = Vector3.zero;

        targetDirection = cameraObject.forward * inputManager.verticalInput;
        targetDirection = targetDirection + cameraObject.right * inputManager.horizontalInput;
        targetDirection.Normalize();
        targetDirection.y = 0;

        if (targetDirection == Vector3.zero) {
            targetDirection = transform.forward;
        }

        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        Quaternion playerRotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        transform.rotation = playerRotation;
    }

    private void HandleFallingAndLanding() {
        RaycastHit hit;
        Vector3 rayCastOrigin = transform.position;
        Vector3 targetPosition;
        rayCastOrigin.y += rayCastHeightOffset;
        targetPosition = transform.position;

        if (!isGrounded && !isJumping) {
            if (!playerManager.isInteracting) {
                animatorManager.PlayTargetAnimation("Falling", true);
            }
            inAirTimer = inAirTimer + Time.deltaTime;

            playerRigidbody.AddForce(transform.forward * leapingVelocity);
            playerRigidbody.AddForce(fallingVelocity * inAirTimer * -Vector3.up);
        }

        if (Physics.SphereCast(rayCastOrigin, 0.2f, -Vector3.up, out hit, maxDistance, groundLayer)) {
            if (!isGrounded && playerManager.isInteracting) {
                animatorManager.PlayTargetAnimation("Land", true);
            }

            Vector3 rayCastHitPoint = hit.point;
            targetPosition.y = rayCastHitPoint.y;
            inAirTimer = 0;
            isGrounded = true;
        } else {
            isGrounded = false;
        }

        if (isGrounded && !isJumping) {
            if (playerManager.isInteracting || inputManager.moveAmount > 0) {
                transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime / 0.1f);
            } else {
                transform.position = targetPosition;
            }
        }
    }

    public void HandleJumping() {
        if (isGrounded) {
            animatorManager.animator.SetBool("isJumping", true);
            animatorManager.PlayTargetAnimation("Jump", false);

            float jumpingVelocity = Mathf.Sqrt(-2 * gravityIntensity * jumpHeight);
            Vector3 playerVelocity = moveDirection;
            playerVelocity.y = jumpingVelocity;
            playerRigidbody.velocity = playerVelocity;
        }
    }

}*/