using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{
    public class  SwapKitchen : MonoBehaviour
    {
        void Start()
        {
            SetInitialReferences();
        }

        void Update()
        {
            if(Utilities.WasItemClicked(gameObject))
            {
                TrySwapKitchen();
            }
        }

        private void TrySwapKitchen()
        {
            if(ArePrerequisitesMet())
            {
                GameManager_References._sceneMaster.AddScene("Kitchen_David");
                GameManager_References._sceneMaster.RemoveScene("Kitchen");
            }
        }

        private bool ArePrerequisitesMet()
        {
            var hasBeenPickedUp = GetComponent<Item_Pickup>().hasBeenPickedUp;
            var doesPlayerHaveItem = Utilities.DoesPlayerHaveItem("PancakeMix");

            var arePrerequesitesMet = hasBeenPickedUp && doesPlayerHaveItem;
            return arePrerequesitesMet;

        }

        private void SetInitialReferences()
        {
        }
    }
}
