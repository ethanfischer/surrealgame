using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S3
{

	public class GameManager_References : MonoBehaviour
	{
		public string playerTag;
		public static string _playerTag;

		public string enemyTag;
		public static string _enemyTag;

		public string audioTag;
		public static string _audioTag;

		public static GameObject _player;
		public static GameObject _audio;

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

			_playerTag = playerTag;
			_enemyTag = enemyTag;
			_audioTag = audioTag;

			_player = GameObject.FindGameObjectWithTag(_playerTag);
			_audio = GameObject.FindGameObjectWithTag(_audioTag);
		}
	}
}
