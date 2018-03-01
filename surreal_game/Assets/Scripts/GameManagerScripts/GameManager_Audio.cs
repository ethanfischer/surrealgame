using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{
	public class GameManager_Audio : MonoBehaviour
	{
		void SetInitialReferences()
		{

		}

		public static void PlaySFX(string sfx)
		{
			foreach (Transform child in GameManager_References._audio.transform)
			{
				if (child.name == sfx)
				{
					child.GetComponent<AudioSource>().Play();
				}
			}
		}



	}

}
