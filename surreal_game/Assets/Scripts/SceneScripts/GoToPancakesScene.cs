using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SurrealGame
{
    public class GoToPancakesScene : GoToScene
    {

        public override bool ArePrerequisitesMet()
        {
            var hasBeenPickedUp = GetComponent<Item_Pickup>().hasBeenPickedUp;
            var doesPlayerHaveItem = Utilities.DoesPlayerHaveItem("PancakeMix");

            var arePrerequesitesMet = hasBeenPickedUp && doesPlayerHaveItem;
            return arePrerequesitesMet;

        }

    }
}
