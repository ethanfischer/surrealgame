using UnityEngine;
using System.Collections;

namespace S3
{
	    
	public class GameManager_ToggleCursor : MonoBehaviour {

        private bool isCursorLocked = true;
        private GameManager_Master gameManagerMaster;
        // Use this for initialization
        private void OnEnable()
        {
            SetInitialReferences();
            gameManagerMaster.MenuToggleEvent += ToggleCursorState;
            //gameManagerMaster.InventoryUIToggleEvent += ToggleCursorState;
        }

        private void OnDisable()
        {
            gameManagerMaster.MenuToggleEvent -= ToggleCursorState;
            //gameManagerMaster.InventoryUIToggleEvent -= ToggleCursorState;
        }

        private void Update()
        {
            CheckIfCursorShouldBeLocked();
        }


        void SetInitialReferences()
        {
            gameManagerMaster = GetComponent<GameManager_Master>();
        }
        
        void ToggleCursorState()
        {
            isCursorLocked = !isCursorLocked;
        }

        void CheckIfCursorShouldBeLocked()
        {
           if(isCursorLocked)
           {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
           }

           else
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
}
