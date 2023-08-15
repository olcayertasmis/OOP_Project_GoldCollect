using DataSystem;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Components")]
        private readonly Rigidbody _rigidBody;
        private readonly PlayerData _playerData;

        #region Generate

        public PlayerMovement(Rigidbody playerRigidBody, PlayerData playerData)
        {
            _rigidBody = playerRigidBody;
            _playerData = playerData;
        }

        #endregion

        #region Movement

        public void MoveToForward()
        {
            Vector3 movementForward = new Vector3(_rigidBody.velocity.x, 0f, _playerData.ForwardMovementSpeed);

            _rigidBody.velocity = movementForward;
        }

        public void MoveToSides(float horizontalInput, Transform playerTransform)
        {
            Vector3 movementSides = new Vector3(horizontalInput * _playerData.SlideMovementSpeed, 0f, _rigidBody.velocity.z);

            _rigidBody.velocity = movementSides;

            var position = playerTransform.position;
            position = new Vector3(Mathf.Clamp(position.x, -_playerData.SlideMovementRange, _playerData.SlideMovementRange), position.y, position.z);
            playerTransform.position = position;
        }

        #endregion
    }
}