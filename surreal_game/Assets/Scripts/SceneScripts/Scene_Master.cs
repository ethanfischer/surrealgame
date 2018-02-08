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

        public delegate void GoToSceneEventHandler(string scene);
        public event GoToSceneEventHandler GoToSceneEvent;

        public void CallGoToSceneEvent(string sceneName)
        {
            if (GoToSceneEvent != null)
            {
                GoToSceneEvent(sceneName);
            }

            var scene = SceneManager.GetSceneByName(sceneName);
            SceneManager.LoadScene(sceneName);
            if(scene.isLoaded)
            {
                SceneManager.SetActiveScene(scene);
            }
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

