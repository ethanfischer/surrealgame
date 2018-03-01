using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SurrealGame
{
    public class  SwitchSceneOnClick : MonoBehaviour
    {
        public string sfx;
        public string nextScene;
        public string currentScene;
        private Scene_Master sceneMaster;

        private void Start()
        {
            SetInitialReferences();
        }

        void Update()
        {
            if(Utilities.WasItemClicked(gameObject))
            {
                TrySwitchScene();
            }
        }

        private void TrySwitchScene()
        {
            if(CanSwitchScene())
            {
                sceneMaster.AddScene(nextScene);
                sceneMaster.RemoveScene(currentScene);
                GameManager_Audio.PlaySFX(sfx);
            }
        }

        private bool CanSwitchScene()
        {
            var hasBeenPickedUp = GetComponent<Item_Pickup>().hasBeenPickedUp;
            var doesPlayerHaveItem = Utilities.DoesPlayerHaveItem("PancakeMix");

            var arePrerequesitesMet = hasBeenPickedUp && doesPlayerHaveItem;
            return arePrerequesitesMet;

        }

        private void SetInitialReferences()
        {
            sceneMaster = GameManager_References._sceneManager.GetComponent<Scene_Master>();
        }
    }
}
