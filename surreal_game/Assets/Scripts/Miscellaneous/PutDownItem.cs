using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{
    public class PutDownItem : MonoBehaviour
    {

        public GameObject item;

        // Use this for initialization
        void Start()
        {
            if (item == null)
            {
                Debug.LogWarning("item not set");
            }

        }

        // Update is called once per frame
        void Update()
        {
            if (Utilities.WasItemClicked(this.gameObject))
            {
                PutDown();
            }

        }

        bool IsItemPickedUp()
        {
            return item.GetComponent<Item_Pickup>().hasBeenPickedUp;
        }

        private void PutDown()
        {
            //put down object
            if (IsItemPickedUp())
            {
                SetParent(item);
                SetPosition(item);
                SetRotation(item);
                item.SetActive(true);
            }
        }

        private void SetPosition(GameObject item)
        {
            item.transform.position = this.transform.position;
        }

        private void SetRotation(GameObject item)
        {
            item.transform.rotation = this.transform.rotation;
        }

        private void SetParent(GameObject item)
        {
            item.transform.SetParent(this.transform);
        }
    }
}

