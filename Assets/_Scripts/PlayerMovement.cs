using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    private bool jumping;
    private bool isGrounded;

    private Vector3 dir;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
        Jump();
    }

    private void OnMovement(InputValue inputValue)
    {
        dir = new Vector3(inputValue.Get<Vector2>().x, rb.velocity.y, inputValue.Get<Vector2>().y);
    }

    private void OnJump(InputValue inputValue)
    {
        if (inputValue.Get<float>() == 1) jumping = true; else jumping = false;
    }

    private void Move()
    {
        rb.velocity = new Vector3(dir.x * speed, rb.velocity.y, dir.z * speed);
    }

    private void Jump()
    {
        if (!jumping || !isGrounded) return;
        isGrounded = false;
        rb.AddForce(transform.up * jumpForce);
    }

    private void OnCollisionEnter(Collision other)
    {
        isGrounded = true;
    }
}
