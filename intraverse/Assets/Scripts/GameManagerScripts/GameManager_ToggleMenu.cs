using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace S3
{
    public class GameManager_ToggleMenu : MonoBehaviour
    {
        private GameManager_Master gameManagerMaster;
        public GameObject menu;
        // Use this for initialization
        void Start()
        {
            //ToggleMenu();
        }

        // Update is called once per frame
        void Update()
        {
            CheckForMenuToggleRequests();
        }

        private void OnEnable()
        {
            SetInitialReferences();
            gameManagerMaster.GameOverEvent += ToggleMenu;
        }

        private void OnDisable()
        {
            gameManagerMaster.GameOverEvent -= ToggleMenu;

        }

        void SetInitialReferences()
        {
            gameManagerMaster = GetComponent<GameManager_Master>();
        }

        void CheckForMenuToggleRequests()
        {
            if(Input.GetKeyUp(KeyCode.Escape)&& !gameManagerMaster.isGameOver && !gameManagerMaster.isInventoryUIOn)
            {
                ToggleMenu();
                //Debug.Log(Time.timeScale);
            }
        }

        void ToggleMenu()
        {
            //Debug.Log("ToggleMenu");
            if(menu != null)
            {
                menu.SetActive(!menu.activeSelf);
                gameManagerMaster.isMenuOn = !gameManagerMaster.isMenuOn;
                gameManagerMaster.CallEventMenuToggle();
            }
            else
            {
                Debug.Log("You need to assign a UIGameObject to the ToggleMenu script in the inspector");
            }
        }
    }

}
