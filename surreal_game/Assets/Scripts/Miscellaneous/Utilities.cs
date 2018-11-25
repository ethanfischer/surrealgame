using UnityEngine;

namespace SurrealGame
{
    public static class Utilities
    {
        public static bool WasItemClicked(GameObject item)
        {
            return IsItemDetected(item) && WasClicked();
        }

        private static bool IsItemDetected(GameObject item)
        {
            return GameManager_References._playerGameObject.GetComponent<Player_Detect_Item>().IsItemDetected(item);
        }

        private static bool WasClicked()
        {
            return Input.GetButtonUp(GameManager_References._interactButton);
        }

        public static bool DoesPlayerHaveItem(string itenName)
        {
            return GameManager_References._playerInventory.Find(itenName);
        }
    }
}
