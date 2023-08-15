using DataSystem;
using TMPro;
using UnityEngine;

namespace UI
{
    public class GoldDisplay : MonoBehaviour
    {
        [Header("Text")]
        [SerializeField] private TMP_Text goldText;

        [Header("Components")]
        private PlayerData _playerData;

        private void OnDisable()
        {
            _playerData.GoldChanged -= OnGoldChanged;
        }

        private void Start()
        {
            _playerData = DataManager.Instance.PlayerData;

            if (_playerData != null) _playerData.GoldChanged += OnGoldChanged;
        }

        private void OnGoldChanged(int value)
        {
            goldText.text = "GOLD: " + _playerData.Gold;
        }
    }
}