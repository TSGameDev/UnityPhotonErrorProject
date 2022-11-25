using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Cinemachine;

namespace TSGameDev.Core.Controls
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] int speed;
        [SerializeField] int runSpeed;

        [HideInInspector]
        public Vector2 movementRaw;
        [HideInInspector]
        public bool isRunning;
        [HideInInspector]
        public bool hasJumped;

        PhotonView PV;
        CharacterController characterController;

        private void Awake()
        {
            PV = GetComponent<PhotonView>();
            characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            Movement();
        }

        public void Movement()
        {
            if (PV.IsMine)
            {
                float rawX = movementRaw.x;
                float rawY = movementRaw.y;

                Vector3 movement;
                movement = (gameObject.transform.right * rawX) + (gameObject.transform.forward * rawY);

                if (isRunning)
                    movement *= runSpeed * Time.deltaTime;
                else
                    movement *= speed * Time.deltaTime;

                if (movement.magnitude >= Mathf.Epsilon)
                    characterController.Move(movement);
            }
        }

        public void Jump()
        {

        }
    }
}
