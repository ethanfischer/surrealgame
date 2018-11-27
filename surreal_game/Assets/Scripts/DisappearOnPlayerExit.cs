using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VIDE_Data;

namespace SurrealGame
{
    public class  DisappearOnPlayerExit : MonoBehaviour
    {

        void Start()
        {
            SetInitialReferences();
			
        }

        void Update()
        {
            if(!GameManager_References._playerGameObject.GetComponent<Player_Detect_Item>().isItemInRange)
            {
                gameObject.SetActive(false);
                VD.EndDialogue();
            }
			
        }

        private void SetInitialReferences()
        {
        }
    }
}
