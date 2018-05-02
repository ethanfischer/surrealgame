using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SurrealGame
{
    public abstract class SwitchSceneOnClick : MonoBehaviour
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
            if (Utilities.WasItemClicked(gameObject))
            {
                TrySwitchScene();
            }
        }

        private void TrySwitchScene()
        {
            if (CanSwitchScene())
            {
                sceneMaster.AddScene(nextScene);
                sceneMaster.RemoveScene(currentScene);
                GameManager_Audio.PlaySFX(sfx);
            }
        }

        protected abstract bool CanSwitchScene();

        private void SetInitialReferences()
        {
            sceneMaster = GameManager_References._sceneManager.GetComponent<Scene_Master>();
        }
    }
}
