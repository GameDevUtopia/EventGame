using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG_PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float groundCheckDistance = 0.5f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private Animator anim;

    private Rigidbody rb;
    private bool isGrounded;
    private Vector3 moveDirection;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // Prevent unwanted rotation
        
        // Cursor 
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        // Handle movement
        MovePlayer();
    }

    private void MovePlayer()
    {
        // Get input
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");

        // Calculate movement direction relative to the camera
        var forward = cameraTransform.forward;
        var right = cameraTransform.right;
        forward.Normalize();
        right.Normalize();

        // Flatten the movement vectors on the horizontal plane
        forward.y = 0f;
        right.y = 0f;

        // Combine movement directions
        moveDirection = (forward * vertical + right * horizontal).normalized;

        if (moveDirection.magnitude < 0.01f)
        {
            anim.SetBool("isWalking", false);
        }
        else
        {
            // Rotate the player to face the movement direction
            var toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, Time.deltaTime * 10f);

            anim.SetBool("isWalking", true);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + moveDirection * (moveSpeed * Time.fixedDeltaTime));
    }
}
