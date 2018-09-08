using SurrealGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.PlayerScripts
{
    public class PlayerInventoryVR : MonoBehaviour, IPlayerInventoryVR
    {
        public GameObject inventoryGameObject;
        private bool wasInitialized = false;
        private GameManager_ToggleInventoryUI InventoryUIScript;
        private Player_Master PlayerMaster;

        List<GameObject> Items;

        public void Add(List<GameObject> itemsToAdd)
        {
            Items.AddRange(itemsToAdd);
        }

        public void SelectItem(GameObject itemToSelect)
        {
            throw new NotImplementedException();
        }
    }
}