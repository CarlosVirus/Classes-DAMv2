using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerEx1 : CharacterEx1, InputSystem_Actions.IPlayerEx1Actions
{
    private InputSystem_Actions inputActions;
    private void Awake()
    {
        inputActions = new InputSystem_Actions();
        inputActions.PlayerEx1.SetCallbacks(this);
    }
    private void OnEnable()
    {
        inputActions.Enable();
    }
    private void OnDisable()
    {
        inputActions.Disable();
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        _jb.Jump();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 direction = context.ReadValue<Vector2>();
        direction.y = 0;
        _mb.Move(direction);
    }
}
