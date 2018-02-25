using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{
    public class  SwapKitchen : MonoBehaviour
    {
        void Update()
        {
            if(Utilities.WasItemClicked(gameObject))
            {
                TrySwapKitchen();
            }
        }

        private void TrySwapKitchen()
        {
            if(CanSwapKitchen())
            {
                GameManager_References._sceneMaster.AddScene("Kitchen_David");
                GameManager_References._sceneMaster.RemoveScene("Kitchen");
            }
        }

        private bool CanSwapKitchen()
        {
            var hasBeenPickedUp = GetComponent<Item_Pickup>().hasBeenPickedUp;
            var doesPlayerHaveItem = Utilities.DoesPlayerHaveItem("PancakeMix");

            var arePrerequesitesMet = hasBeenPickedUp && doesPlayerHaveItem;
            return arePrerequesitesMet;

        }
    }
}
