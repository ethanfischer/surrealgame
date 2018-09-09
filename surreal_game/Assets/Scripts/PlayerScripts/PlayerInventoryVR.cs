using SurrealGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.PlayerScripts
{
    public class PlayerInventoryVR : MonoBehaviour, IPlayerInventory
    {
        public GameObject InventoryGameObject;
        private bool wasInitialized = false;
        private GameManager_ToggleInventoryUI InventoryUIScript;
        private Player_Master PlayerMaster;

        List<GameObject> Items = new List<GameObject>();

        public void Add(GameObject itemToAdd)
        {
            Items.Add(itemToAdd);
            AddItemAsChildAndResetTransform(itemToAdd);
        }

        public void SelectItem(GameObject itemToSelect)
        {
            throw new NotImplementedException();
        }

        private void AddItemAsChildAndResetTransform(GameObject gameObject)
        {
            gameObject.transform.parent = InventoryGameObject.transform;
            gameObject.transform.localPosition = Vector3.zero;
            gameObject.transform.localRotation = Quaternion.identity;
            gameObject.transform.localScale = Vector3.one;
        }
    }
}