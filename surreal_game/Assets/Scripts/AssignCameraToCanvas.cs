using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SurrealGame
{
    public class AssignCameraToCanvas : MonoBehaviour
    {
        public Canvas Canvas;
        void Start()
        {
            var camera = Camera.main;
            Canvas.worldCamera = camera;
        }
    }
}
