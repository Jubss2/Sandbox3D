using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float force;

    private Rigidbody rb;

    private PlayerControls inputs;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        inputs = new PlayerControls();
    }
    private void OnEnable()
    {
        inputs.Enable();
        inputs.Player.Jump.performed += Jump;

    }

    private void OnDisable()
    {
        inputs.Disable();
        
    }

    private void Jump(InputAction.CallbackContext ctx)
    {
        rb.AddForce(Vector3.up * force, ForceMode.Impulse);
    }
}
