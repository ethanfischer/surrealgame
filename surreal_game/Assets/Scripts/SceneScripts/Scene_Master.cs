using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SurrealGame
{

    public class Scene_Master : MonoBehaviour
    {
        private Player_Master playerMaster;
        private SceneManager sceneManager;

        public delegate void AddSceneEventHandler(string scene);
        public event AddSceneEventHandler AddSceneEvent;

        public delegate void RemoveSceneEventHandler(string scene);
        public event RemoveSceneEventHandler RemoveSceneEvent;

        public void AddScene(string sceneName)
        {
            if (AddSceneEvent != null)
            {
                AddSceneEvent(sceneName);
            }

            var scene = SceneManager.GetSceneByName(sceneName);
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        }

        internal void RemoveScene(string sceneName)
        {
            if (RemoveSceneEvent != null)
            {
                RemoveSceneEvent(sceneName);
            }

            var scene = SceneManager.GetSceneByName(sceneName);
            SceneManager.UnloadSceneAsync(scene);
        }

        void SetInitialReferences()
        {
            sceneManager = new SceneManager();

        }

        // Use this for initialization
        void Start()
        {
            SetInitialReferences();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}

