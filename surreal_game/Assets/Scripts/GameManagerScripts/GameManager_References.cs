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

        public string interactButton;
        public static string _interactButton;

		public static GameObject _player;
		public static GameObject _audio;
        public static GameObject _mainCamera;

        public Transform playerInventory;
        public static Transform _playerInventory;

        public Scene_Master sceneMaster;
        public static Scene_Master _sceneMaster;

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

            if (interactButton == "")
			{
				Debug.LogWarning("Please type in a interactButton in the GameManager_References inspector slot");
			}

            if (playerInventory == null)
			{
				Debug.LogWarning("Please type in a playerInventory in the GameManager_References inspector slot");
			}

            if (sceneMaster == null)
			{
				Debug.LogWarning("Please type in a sceneMaster in the GameManager_References inspector slot");
			}


			_playerTag = playerTag;
			_enemyTag = enemyTag;
			_audioTag = audioTag;
            _mainCameraTag = mainCameraTag;
            _interactButton = interactButton;
            _playerInventory = playerInventory;
            _sceneMaster = sceneMaster;

			_player = GameObject.FindGameObjectWithTag(_playerTag);
			_audio = GameObject.FindGameObjectWithTag(_audioTag);
			_mainCamera= GameObject.FindGameObjectWithTag(_mainCameraTag);
		}
	}
}
