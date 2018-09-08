using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.PlayerScripts
{
    public interface IPlayerInventoryVR
    {
        void Add(List<GameObject> itemsToAdd);
        void SelectItem(GameObject itemToSelect);
    }
}