using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{

	public class GameManager_References : MonoBehaviour
	{
		public string playerTag;
		public static string _playerTag;

		public string enemyTag;
		public static string _enemyTag;

		public string audioTag;
		public static string _audioTag;

        public string mainCameraTag;
		public static string _mainCameraTag;

        public string pickupButton;
        public static string _pickupButton;

		public static GameObject _player;
		public static GameObject _audio;
        public static GameObject _mainCamera;
        public Transform playerInventory;
        public static Transform _playerInventory;

        private void OnEnable()
		{
			if (playerTag == "")
			{
				Debug.LogWarning("Please type in a playerTag in the GameManager_References inspector slot");
			}

			if (enemyTag == "")
			{
				Debug.LogWarning("Please type in a enemyTag in the GameManager_References inspector slot");
			}

			if (audioTag == "")
			{
				Debug.LogWarning("Please type in a audioTag in the GameManager_References inspector slot");
			}

            if (mainCameraTag == "")
			{
				Debug.LogWarning("Please type in a cameraTag in the GameManager_References inspector slot");
			}

            if (pickupButton == "")
			{
				Debug.LogWarning("Please type in a pikcupButton in the GameManager_References inspector slot");
			}

            if (_playerInventory == null)
			{
				Debug.LogWarning("Please type in a plaerInventory in the GameManager_References inspector slot");
			}


			_playerTag = playerTag;
			_enemyTag = enemyTag;
			_audioTag = audioTag;
            _mainCameraTag = mainCameraTag;
            _pickupButton = pickupButton;
            _playerInventory = playerInventory;

			_player = GameObject.FindGameObjectWithTag(_playerTag);
			_audio = GameObject.FindGameObjectWithTag(_audioTag);
			_mainCamera= GameObject.FindGameObjectWithTag(_mainCameraTag);
		}
	}
}
