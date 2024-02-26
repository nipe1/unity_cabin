using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class CameraManager : MonoBehaviour {

    private InputManager inputManager;

    private Transform targetTransform; // The object the camera will follow
    [SerializeField] private Transform cameraPivot; // The object the camera uses to pivot
    [SerializeField] private LayerMask collisionLayers; // The layers we want our camera to collide with

    private Transform cameraTransform; // The transform of the actual camera object in the scene
    private float defaultPosition;
    private const float sprintModifier = -1.5f;
    private const float runTowardsModifier = -1;
    private Vector3 cameraFollowVelocity = Vector3.zero;
    private Vector3 cameraVectorPosition;
    private float cameraTimer = 0;
    private float cameraTransitionDuration = 0.75f;

    [SerializeField] private float cameraCollisionOffset = 0.2f; // How much the camera will jump off of objects its colliding with
    [SerializeField] private float minimumCollisionOffset = 0.2f;
    [SerializeField] private float cameraFollowSpeed = 0.2f;
    [SerializeField] private float cameraLookSpeed = 2;
    [SerializeField] private float cameraPivotSpeed = 2;
    [SerializeField] private float cameraCollisionRadius = 0.08f;
    

    public float lookAngle; // Camera looking up and down
    public float pivotAngle; // Camera looking left and right

    [SerializeField] private float minPivotAngle = -35;
    [SerializeField] private float maxPivotAngle = 55;

    private void Awake() {
        targetTransform = FindObjectOfType<PlayerManager>().transform;
        inputManager = FindObjectOfType<InputManager>();
        cameraTransform = Camera.main.transform;
        defaultPosition = cameraTransform.localPosition.z;
    }

    public void HandleAllCameraMovement() {
        FollowTarget();
        HandleCameraDistance();
        RotateCamera();
        HandleCameraCollisions();
    }

    private void FollowTarget() {
        Vector3 targetPosition = Vector3.SmoothDamp(transform.position, targetTransform.position, ref cameraFollowVelocity, cameraFollowSpeed);
        transform.position = targetPosition;
    }

    private void HandleCameraDistance() {

        cameraVectorPosition.z = defaultPosition;

        if (inputManager.IsSprinting()) 
            cameraVectorPosition.z += sprintModifier;

        if (inputManager.RunningTowardsCamera()) 
            cameraVectorPosition.z += runTowardsModifier;
        
        if (cameraTransform.localPosition != cameraVectorPosition) {
            cameraTransform.localPosition = Vector3.Lerp(cameraTransform.localPosition, cameraVectorPosition, cameraTimer / cameraTransitionDuration);
            cameraTimer += Time.deltaTime;
        } else {
            cameraTimer = 0;
        }
    }

    private void RotateCamera() {
        Vector3 rotation;
        Quaternion targetRotation;

        lookAngle += (inputManager.cameraInputX * cameraLookSpeed);
        pivotAngle -= (inputManager.cameraInputY * cameraPivotSpeed);
        pivotAngle = Mathf.Clamp(pivotAngle, minPivotAngle, maxPivotAngle);

        rotation = Vector3.zero;
        rotation.y = lookAngle;
        targetRotation = Quaternion.Euler(rotation);
        transform.rotation = targetRotation;

        rotation = Vector3.zero;
        rotation.x = pivotAngle;
        targetRotation = Quaternion.Euler(rotation);
        cameraPivot.localRotation = targetRotation;

    }

    private void HandleCameraCollisions() {

        float targetPosition = cameraVectorPosition.z;
        RaycastHit hit;
        Vector3 direction = cameraTransform.position - cameraPivot.position;
        direction.Normalize();

        if (Physics.SphereCast(cameraPivot.transform.position, cameraCollisionRadius, direction, out hit, Mathf.Abs(targetPosition), collisionLayers)) {
            float distance = Vector3.Distance(cameraPivot.position, hit.point);
            targetPosition =- (distance - cameraCollisionOffset);
        } else return;

        if (Mathf.Abs(targetPosition) < minimumCollisionOffset) {
            targetPosition -= minimumCollisionOffset;
        }

        cameraVectorPosition.z = targetPosition; //Mathf.Lerp(cameraTransform.localPosition.z, targetPosition, 0.2f);
        cameraTransform.localPosition = cameraVectorPosition;
    }

}*/