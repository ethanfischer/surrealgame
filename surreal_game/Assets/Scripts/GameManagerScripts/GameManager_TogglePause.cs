using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S3
{
    public class GameManager_TogglePause : MonoBehaviour
    {
        GameManager_Master gameManager_Master;
        private bool isPaused;

        private void OnEnable()
        {
            SetInitialReferences();
            gameManager_Master.MenuToggleEvent += TogglePause;
            //gameManager_Master.InventoryUIToggleEvent += TogglePause;
        }

        private void OnDisable()
        {
            gameManager_Master.MenuToggleEvent -= TogglePause;
            //gameManager_Master.InventoryUIToggleEvent -= TogglePause;
        }

        void SetInitialReferences()
        {
            gameManager_Master = GetComponent<GameManager_Master>();
        }

        void TogglePause()
        {
         
            if(isPaused)
            {
                Time.timeScale = 1;
                isPaused = false;
            }
            else
            {
                Time.timeScale = 0;
                isPaused = true;
            }
            //Debug.Log("isPaused = " + isPaused);
        }
    }

}

