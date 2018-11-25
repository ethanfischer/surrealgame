using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SurrealGame
{
    public class IndicateItemDetected : MonoBehaviour
    {
        private RectTransform initialRect;
        public Image image;
        public Color defaultColor;
        public Color highlightColor;
        void Start()
        {
            SetInitialReferences();

        }

        void Update()
        {
            if (GameManager_References._playerGameObject.GetComponent<Player_Detect_Item>().isItemInRange)
            {
                image.color = highlightColor;
            }
            else
            {
                image.color = defaultColor;
            }
        }

        private void SetInitialReferences()
        {
            image = GetComponent<Image>();
        }
    }
}
