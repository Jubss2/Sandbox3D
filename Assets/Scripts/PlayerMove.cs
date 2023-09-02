using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;

    private PlayerControls inputs;

    [SerializeField] private float speed = 50f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        inputs = new PlayerControls();
    }
    private void OnEnable()
    {
        inputs.Enable();
        inputs.Player.Move.performed += Move;
        inputs.Player.Move.canceled += Move;
    }

    private void OnDisable()
    {
        inputs.Disable(); 
        inputs.Player.Move.performed -= Move;
        inputs.Player.Move.canceled -= Move;
    }
    private void Update()
    {
        
    }
    private void Move(InputAction.CallbackContext ctx)
    {
        var movementDirection = ctx.ReadValue<Vector2>();
        rb.velocity = new Vector3(movementDirection.x, 0f, movementDirection.y) * speed;
    }

}
