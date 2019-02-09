using UnityEngine;

namespace Assets.Scripts.PlayerScripts
{
    public interface IPlayerInventory
    {
        void Add(GameObject itemToAdd);
        void SelectItem(GameObject itemToSelect);
        bool HasItem(string itemName);
    }
}