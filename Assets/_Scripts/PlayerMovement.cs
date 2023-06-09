using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private float mouseSensitivity = 100.0f;
    private bool jumping;
    private bool isGrounded;

    private Vector3 dir;

    [SerializeField] private Camera camera;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        MouseMovement();
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
        rb.velocity = transform.forward * dir.z * speed + new Vector3(0, rb.velocity.y, 0) + transform.right * dir.x * speed;
    }

    private void Jump()
    {
        if (!jumping || !isGrounded) return;
        isGrounded = false;
        rb.AddForce(transform.up * jumpForce);
    }

    private void MouseMovement()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        camera.transform.Rotate(new Vector3(-mouseY, 0, 0));
        transform.Rotate(new Vector3(0, mouseX, 0));
    }

    private void OnCollisionEnter(Collision other)
    {
        isGrounded = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
