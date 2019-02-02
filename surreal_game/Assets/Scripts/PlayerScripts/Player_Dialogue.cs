using UnityEngine;
using System.Collections;
using VIDE_Data;

namespace SurrealGame
{
    public class Player_Dialogue : MonoBehaviour
    {
        //Reference to our diagUI script for quick access
        public Dialogue_UI diagUI;

        public void TryInteract(GameObject npc)
        {
            VIDE_Assign assigned;
            if (npc.GetComponent<VIDE_Assign>() != null)
            {
                assigned = npc.GetComponent<VIDE_Assign>();
            }
            else
            {
                return;
            }

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
