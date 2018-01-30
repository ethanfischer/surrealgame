using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

namespace SurrealGame
{
    

    public class GameManager_TogglePlayer : MonoBehaviour
    {
        public GameObject fpsController;
        private GameManager_Master gameManagerMaster;

        private void OnEnable()
        {
           SetInitialReferences();
           gameManagerMaster.MenuToggleEvent += TogglePlayerController;
           gameManagerMaster.InventoryUIToggleEvent += TogglePlayerController;
            gameManagerMaster.CutsceneTerminatedEvent += TogglePlayerController;
        }

        private void OnDisable()
        {
           gameManagerMaster.MenuToggleEvent -= TogglePlayerController;
           gameManagerMaster.InventoryUIToggleEvent -= TogglePlayerController;
            gameManagerMaster.CutsceneTerminatedEvent -= TogglePlayerController;
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
            if(fpsController != null)
            {
                fpsController.GetComponent<FirstPersonController>().enabled = !fpsController.GetComponent<FirstPersonController>().enabled;
            }
        }
    }
}