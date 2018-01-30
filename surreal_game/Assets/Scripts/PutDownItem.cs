using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{
    public class PutDownItem : MonoBehaviour
    {

        public GameObject gameObject;

        // Use this for initialization
        void Start()
        {
            if (gameObject == null)
            {
                Debug.LogWarning("gameObject not set");
            }

        }

        // Update is called once per frame
        void Update()
        {
            if (GetComponent<DetectClick>().WasClicked())
            {
                //put down object
                if (IsItemPickedUp())
                {
                    gameObject.transform.SetParent(this.transform);
                    gameObject.transform.position = this.transform.position;
                    gameObject.transform.localPosition = new Vector3(-.15f, .19f, 0);
                    gameObject.SetActive(true);
                }
            }

        }

        bool IsItemPickedUp()
        {
            return gameObject.GetComponent<Item_Pickup>().isPickedUp;
        }
    }
}

