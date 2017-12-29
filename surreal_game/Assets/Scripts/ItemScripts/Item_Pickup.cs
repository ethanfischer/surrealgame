using UnityEngine;
using System.Collections;

namespace S3
{
	public class Item_Pickup : MonoBehaviour
	{

		private Item_Master itemMaster;
		public string pickupSFX = "sfx_item_pickup";

		void OnEnable()
		{
			SetInitialReferences();
			itemMaster.EventPickupAction += CarryOutPickupActions;
		}

		void OnDisable()
		{
			itemMaster.EventPickupAction -= CarryOutPickupActions;
		}

		void SetInitialReferences()
		{
			itemMaster = GetComponent<Item_Master>();
		}

		void CarryOutPickupActions(Transform tParent)
		{
			if (!CheckIfLocked())
			{
				transform.SetParent(tParent);
				itemMaster.CallEventObjectPickup();
				transform.gameObject.SetActive(false);
				GameManager_Audio.PlaySFX(pickupSFX);
				Debug.Log("picking up item");
			}

		}

		bool CheckIfLocked()
		{
			foreach (Transform child in gameObject.transform)
			{
				//Debug.Log(gameObject.name + " has children");
				if (child.gameObject.CompareTag("Lock"))
				{
					if (child.gameObject.activeInHierarchy)
					{
						//Debug.Log(this.name + " has a lock");
						//attempt to lock any locked items (Item Lock checks if player has the key)
						if(child.GetComponent<Item_Lock>().Unlock())
						{
							return false; //We want to carry out the pickup action simultaneously with the items being unlocked. 
						}
						return true;
					}
					//Debug.Log(child.name + "a in h: " + child.gameObject.activeInHierarchy);
				}
				//Debug.Log(gameObject.name + " child doesn't have Lock tag");
			}
			return false;
		}
	}
}


