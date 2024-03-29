﻿using UnityEngine;

namespace SurrealGame
{
    public static class Utilities
    {
        public static bool WasItemClicked(out Transform item)
        {
            return IsItemDetected(out item) && DidClick();
        }

        public static bool IsItemDetected(out Transform item) => GameManager_References._playerGameObject.GetComponent<Player_Detect_Item>().IsItemDetected(out item);

        public static bool DidClick()
        {
            return Input.GetButtonUp(GameManager_References._interactButton);
        }

        public static bool DoesPlayerHaveItem(string itenName)
        {
            return GameManager_References._playerInventory.Find(itenName);
        }
    }
}
