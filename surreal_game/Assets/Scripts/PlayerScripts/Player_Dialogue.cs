using UnityEngine;
using System.Collections;
using VIDE_Data;

namespace SurrealGame
{
    public class Player_Dialogue : MonoBehaviour
    {
        //This script handles player movement and interaction with other NPC game objects

        //Reference to our diagUI script for quick access
        public Dialogue_UI diagUI;

        void Start()
        {
        }

        void Update()
        {
            //Interact with NPCs when hitting spacebar
            //if (Input.GetKeyDown(KeyCode.E))
            //{
            //    TryInteract();
            //}
            ////Hide/Show cursor
            //if (Input.GetMouseButtonDown(0))
            //{/*
            //Cursor.visible = !Cursor.visible;
            //if (Cursor.visible)
            //    Cursor.lockState = CursorLockMode.None;
            //else
            //    Cursor.lockState = CursorLockMode.Locked;*/
            //}
        }

        public void TryInteract(GameObject npc)
        {
            //In this example, we will try to interact with any collider the raycast finds

            //Lets grab the NPC's DialogueAssign script... if there's any
            VIDE_Assign assigned;
            if (npc.GetComponent<VIDE_Assign>() != null)
                assigned = npc.GetComponent<VIDE_Assign>();
            else return;


            if (!VD.isActive)
            {
                //... and use it to begin the conversation
                //We use a different UIManager depending on the alias of the dialogue
                diagUI.Begin(assigned);
            }
            else
            {
                //If conversation already began, let's just progress through it
                diagUI.CallNext();
            }

        }
    }
}
