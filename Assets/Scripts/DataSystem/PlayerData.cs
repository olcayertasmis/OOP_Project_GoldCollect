using System;
using UnityEngine;

namespace DataSystem
{
    [CreateAssetMenu(fileName = "Player Data", menuName = "New Player Data")]
    public class PlayerData : ScriptableObject
    {
        [Header("Movement")]
        [SerializeField] private float slideMovementSpeed;
        [SerializeField] private float slideMovementRange;
        [SerializeField] private float forwardMovementSpeed;

        #region Helpers

        public float SlideMovementSpeed => slideMovementSpeed;
        public float SlideMovementRange => slideMovementRange;
        public float ForwardMovementSpeed => forwardMovementSpeed;

        #endregion


        [Header("Gold")]
        private int _gold;
        public event Action<int> GoldChanged;

        public int Gold
        {
            get => _gold;
            set
            {
                _gold = value;
                GoldChanged?.Invoke(_gold);
            }
        }
    }
}