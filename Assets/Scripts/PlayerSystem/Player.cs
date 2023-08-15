using DataSystem;
using UnityEngine;

namespace PlayerSystem
{
    public class Player : MonoBehaviour
    {
        [Header("Components")]
        [SerializeField] private PlayerData playerData;
        [SerializeField] private Rigidbody rigidBody;
        private PlayerMovement _playerMovement;

        [Header("Controls")]
        private bool _canSlides;

        [Header("Variables")]
        private float _horizontalInput;


        private void Start()
        {
            _playerMovement = UpdatePlayerMovement();
        }

        private void FixedUpdate()
        {
            _playerMovement.MoveToForward();

            if (_canSlides) _playerMovement.MoveToSides(_horizontalInput, transform);
        }

        private void Update()
        {
            _horizontalInput = Input.GetAxis("Horizontal");

            _canSlides = Mathf.Abs(_horizontalInput) > 0.1f;
        }

        private PlayerMovement UpdatePlayerMovement()
        {
            return new PlayerMovement(rigidBody, playerData);
        }
    }
}