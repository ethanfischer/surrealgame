using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{
    public class NPC_Player_Interaction : MonoBehaviour
    {
        Player_Dialogue playerDialogue;

        void Start()
        {
            SetInitialReferences();

        }

        void Update()
        {
            //if (Utilities.WasItemClicked(gameObject))
            //{
            //    playerDialogue.TryInteract(gameObject);
            //}

        }

        private void SetInitialReferences()
        {
            playerDialogue = GameManager_References._playerGameObject.GetComponent<Player_Dialogue>();
        }
    }
}