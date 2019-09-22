using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.PlayerScripts
{
    public class Player_Detect_UI : MonoBehaviour
    {
        [Tooltip("What layer is being used for items")]
        public LayerMask layerToDetect;
        [Tooltip("What transform will the ray be fired from?")]
        public Transform rayTransformPivot;

        private GameObject detectedItem;
        public bool isUIInRange;
        public string detectedItemName;

        void Update()
        {
            CastRayForDetectingItems();
        }

        void CastRayForDetectingItems()
        {
            Debug.DrawRay(rayTransformPivot.position, rayTransformPivot.forward, Color.blue, .01f, depthTest: false);
            var pointerEventData = new PointerEventData(EventSystem.current)
            {
                position = Input.mousePosition
            };

            var results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerEventData, results);

            if (results.Count > 0)
            {
                CheckResultsForUIElement(results);
            }
            else
            {
                isUIInRange = false;
                detectedItemName = "";
            }
        }

        private void CheckResultsForUIElement(List<RaycastResult> results)
        {
            foreach (var result in results)
            {
                if (result.gameObject.layer == LayerMask.NameToLayer("UI"))
                {
                    detectedItem = result.gameObject;
                    detectedItemName = detectedItem.name;
                    Debug.Log("Detected " + detectedItemName);
                    isUIInRange = true;
                    break;
                }
            }
        }
    }
}
