using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{
	public class Item_Lock : MonoBehaviour
	{
		//private bool isLocked;
		public string keyName;
		private string unlockSFX = "tinker6";

		void OnEnable()
		{
			SetInitialReferences();
		}

		void OnDisable()
		{

		}

		void SetInitialReferences()
		{
			//isLocked = true;
		}

		// Use this for initialization
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{

		}

		public bool Unlock()
		{
			//TODO check if hastherightkey
			if (CheckIfPlayerHasKey())
			{
				//isLocked = false;
				gameObject.SetActive(false);
				GameManager_Audio.PlaySFX("sfx_unlock");
				Debug.Log("Unlocked: " + this.name);
				return true;
			}
			return false;
		}

		bool CheckIfPlayerHasKey()
		{
			Debug.Log("checkifplayerhaskey");
			//player.GetComponent<Player_Master>().GetHasKey();
			Transform inventoryPlayerParent = GameManager_References._player.GetComponent<Player_Inventory_NonVR>().inventoryPlayerParent;
			foreach (Transform child in inventoryPlayerParent)
			{
				Debug.Log("child in inventoryPlayerParent: " + child);
				if (child.name == keyName)
				{
					return true;
				}
			}
			GameManager_Audio.PlaySFX("sfx_lock");
			return false;
		}
	}

}
