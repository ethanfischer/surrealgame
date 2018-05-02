using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{
    public class  DeactivateOnStart : MonoBehaviour
    {

        void Start()
        {
            gameObject.SetActive(false);
        }
    }
}
