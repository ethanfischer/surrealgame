using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S3
{
    

    public class GameManager_TogglePlayer : MonoBehaviour
    {
        public GameObject head;
        private GameManager_Master gameManagerMaster;

        private void OnEnable()
        {
           SetInitialReferences();
           gameManagerMaster.MenuToggleEvent += TogglePlayerController;
           gameManagerMaster.InventoryUIToggleEvent += TogglePlayerController;
        }

        private void OnDisable()
        {
           gameManagerMaster.MenuToggleEvent -= TogglePlayerController;
           gameManagerMaster.InventoryUIToggleEvent -= TogglePlayerController;
        }

        private void OnMouseEnter()
        {
            
        }


        void SetInitialReferences()
        {
            gameManagerMaster = GetComponent<GameManager_Master>();
        }

        private void TogglePlayerController()
        {
            if(head != null)
            {
                //head.GetComponent<GvrHead>().enabled = !head.GetComponent<GvrHead>().enabled;
            }
        }
    }
}