using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S3
{

	public class GameManager_RestartLevel : MonoBehaviour
	{
		private GameManager_Master gameManagerMaster;
		// Use this for initialization

		private void OnEnable()
		{
			SetInitialReferences();
			gameManagerMaster.RestartLevelEvent += RestartLevel;
		}

		private void OnDisable()
		{
			gameManagerMaster.RestartLevelEvent -= RestartLevel;
		}

		void SetInitialReferences()
		{
			gameManagerMaster = GetComponent<GameManager_Master>();
		}

		void RestartLevel()
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}

}