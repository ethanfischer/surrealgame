using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.PlayerScripts
{
    public class Player_Detect_UI : MonoBehaviour
    {
        [Tooltip("What layer is being used for items")]
        public LayerMask layerToDetect;
        [Tooltip("What transform will the ray be fired from?")]
        public Transform rayTransformPivot;
        [Tooltip("The editor input button that will be used for picking up items")]

        private Transform detectedItem;
        private RaycastHit hit;
        public float detectRange = 100f;
        //public float detectRadius = 0.1f;
        public bool isUIInRange;
        public string detectedItemName;

        void Update()
        {
            CastRayForDetectingItems();
        }

        void CastRayForDetectingItems()
        {
            Debug.DrawRay(rayTransformPivot.position, rayTransformPivot.forward, Color.blue, .01f, depthTest: false);
            if (Physics.Raycast(rayTransformPivot.position, rayTransformPivot.forward, out hit, detectRange, layerToDetect))
            {
                detectedItem = hit.transform;
                detectedItemName = detectedItem.name;
                Debug.Log("Detected " + detectedItemName);
                isUIInRange = true;
            }
            else
            {
                isUIInRange = false;
                detectedItemName = "";
            }
        }
    }
}
