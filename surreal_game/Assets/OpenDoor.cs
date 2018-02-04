using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{
    public class  OpenDoor : MonoBehaviour
    {
        void Start()
        {
            SetInitialReferences();
			
        }

        void Update()
        {
            if(Utilities.WasItemClicked(gameObject))
            {
                gameObject.SetActive(false);
            }
			
        }

        private void SetInitialReferences()
        {
        }
    }
}
