using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public event EventHandler<Vector2> OnMove;

    private PlayerInput playerInput;

    private InputAction moveAction;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions["Move"];
    }

    private void OnEnable()
    {
        moveAction.performed += OnMoveAction;
        moveAction.canceled += OnMoveAction;
    }

    private void OnDisable()
    {
        moveAction.performed -= OnMoveAction; 
        moveAction.canceled -= OnMoveAction;
    }

    private void OnMoveAction(InputAction.CallbackContext context)
    {
        OnMove?.Invoke(this, context.ReadValue<Vector2>());
    }
}
