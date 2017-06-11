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

		public static GameObject _player;

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

			_playerTag = playerTag;
			_enemyTag = enemyTag;

			_player = GameObject.FindGameObjectWithTag(_playerTag);
		}
	}
}
