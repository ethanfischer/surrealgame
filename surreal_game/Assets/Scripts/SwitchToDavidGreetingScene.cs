using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SurrealGame
{
    public class  SwitchToDavidGreetingScene : SwitchSceneOnClick
    {
        protected override bool CanSwitchScene()
        {
            var hasBeenPickedUp = GetComponent<Item_Pickup>().hasBeenPickedUp;
            var doesPlayerHaveItem = Utilities.DoesPlayerHaveItem("PancakeMix");

            var arePrerequesitesMet = hasBeenPickedUp && doesPlayerHaveItem;
            return arePrerequesitesMet;

        }
    }
}
