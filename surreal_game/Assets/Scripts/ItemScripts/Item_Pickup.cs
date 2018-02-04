using UnityEngine;
using System.Collections;

namespace SurrealGame
{
    public class Item_Pickup : MonoBehaviour
    {

        private Item_Master itemMaster;
        public string pickupSFX = "sfx_item_pickup";
        public bool hasBeenPickedUp = false;
        private Transform playerInventory;

        private void Update()
        {
            CheckForPickupAttempt();
        }

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
            playerInventory = GameManager_References._playerInventory;
        }

        void CarryOutPickupActions(Transform tParent)
        {
            transform.SetParent(tParent);
            itemMaster.CallEventObjectPickup();
            transform.gameObject.SetActive(false);
            GameManager_Audio.PlaySFX(pickupSFX);
            hasBeenPickedUp = true;
        }


        bool IsLocked()
        {
            foreach (Transform child in gameObject.transform)
            {
                if (child.gameObject.CompareTag("Lock"))
                {
                    if (child.gameObject.activeInHierarchy)
                    {
                        //attempt to lock any locked items (Item Lock checks if player has the key)
                        if (child.GetComponent<Item_Lock>().Unlock())
                        {
                            return false; //We want to carry out the pickup action simultaneously with the items being unlocked. 
                        }
                        return true;
                    }
                }
            }
            return false;
        }

        private void CheckForPickupAttempt()
        {
            if (Utilities.WasItemClicked(gameObject) && !IsLocked() && !hasBeenPickedUp)
            {
                GetComponent<Item_Master>().CallEventPickupAction(playerInventory);
            }

        }

    }
}


