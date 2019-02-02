using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{
    public class HideOnStart : MonoBehaviour
    {
        Player_Dialogue playerDialogue;

        void Start()
        {
            gameObject.SetActive(false);
        }
    }
}