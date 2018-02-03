using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{
    public class Player_Detect_Item : MonoBehaviour
    {
        [Tooltip("What layer is being used for items")]
        public LayerMask layerToDetect;
        [Tooltip("What transform will the ray be fired from?")]
        public Transform rayTransformPivot;
        [Tooltip("The editor input button that will be used for picking up items")]

        private Transform detectedItem;
        private RaycastHit hit;
        public float detectRange = 3f;
        public float detectRadius = 0.1f;
        public bool isItemInRange;
        public string detectedItemName;

        // Update is called once per frame
        void Update()
        {
            CastRayForDetectingItems();
        }

        void CastRayForDetectingItems()
        {
            if (Physics.SphereCast(rayTransformPivot.position, detectRadius, rayTransformPivot.forward, out hit, detectRange, layerToDetect))
            {
                detectedItem = hit.transform;
                detectedItemName = detectedItem.name;
                isItemInRange = true;
            }
            else
            {
                isItemInRange = false;
                detectedItemName = "";
            }
        }

        public GameObject GetDetectedItem()
        {
            return detectedItem.gameObject;
        }

        public bool IsItemDetected(GameObject item)
        {
            return item.name == detectedItemName;
        }
    }

}
