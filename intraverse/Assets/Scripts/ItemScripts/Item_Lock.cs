using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S3
{
	public class Item_Lock : MonoBehaviour
	{
		//private bool isLocked;
		public string keyName;

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

		public void Unlock()
		{
			//TODO check if hastherightkey
			if (CheckIfPlayerHasKey())
			{
				//isLocked = false;
				gameObject.SetActive(false);
				Debug.Log("Unlocked: " + this.name);
			}
		}

		bool CheckIfPlayerHasKey()
		{
			Debug.Log("checkifplayerhaskey");
			//player.GetComponent<Player_Master>().GetHasKey();
			Transform inventoryPlayerParent = GameManager_References._player.GetComponent<Player_Inventory>().inventoryPlayerParent;
			foreach (Transform child in inventoryPlayerParent)
			{
				Debug.Log("child in inventoryPlayerParent: " + child);
				if (child.name == keyName)
				{
					return true;
				}
			}
			return false;
		}
	}
	
}
