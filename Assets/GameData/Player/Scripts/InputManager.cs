using UnityEngine;

namespace TSGameDev.Core.Controls
{
    public class InputManager : MonoBehaviour
    {
        PlayerMovement playerMovement;
        PlayerControls playerControls;

        private void Awake()
        {
            playerMovement = GetComponent<PlayerMovement>();
            playerControls = new();
        }

        private void OnEnable()
        {
            playerControls.Enable();
            playerControls.Game.Enable();

            playerControls.Game.Movement.performed += ctx => playerMovement.movementRaw = ctx.ReadValue<Vector2>();
            playerControls.Game.Movement.canceled += ctx => playerMovement.movementRaw = new();
            playerControls.Game.Run.performed += ctx => playerMovement.isRunning = !playerMovement.isRunning;
            playerControls.Game.Jump.performed += ctx => playerMovement.Jump();

        }

        private void OnDisable()
        {
            playerControls.Disable();
            playerControls.Game.Disable();
        }
    }
}
