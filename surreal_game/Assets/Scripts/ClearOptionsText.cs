using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SurrealGame
{
    public class ClearOptionsText : MonoBehaviour
    {
        public List<Text> options;
        void Start()
        {
            foreach (Text option in options)
            {
                option.text = "";
            }
        }
    }
}
