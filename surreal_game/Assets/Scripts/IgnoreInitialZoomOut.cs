//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//namespace SurrealGame
//{
//    public class IgnoreInitialZoomOut : MonoBehaviour
//    {
//        private object gameManagerMaster;

//        void Start()
//        {
//            SetInitialReferences();

//        }

//        private IEnumerable Wait(float v)
//        {
//            yield return new WaitForSeconds(5);

//        }

//        void Update()
//        {
//            if (Input.GetKey(KeyCode.Space))
//            {
//                var maxFOV = GetComponent<SmoothZoom>().maxFOV;
//                Camera.main.fieldOfView = maxFOV;
//                GetComponent<SmoothZoom>().enabled = false;
//            }
//        }

//        private void SetInitialReferences()
//        {
//            gameManagerMaster = 
//        }
//    }
//}
