using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SurrealGame
{

    public class Scene_Master : MonoBehaviour
    {
        public delegate void AddSceneEventHandler(string scene);
        public event AddSceneEventHandler EventAddScene;

        public delegate void RemoveSceneEventHandler(string scene);
        public event RemoveSceneEventHandler EventRemoveScene;

        public void AddScene(string sceneName)
        {
            if (EventAddScene != null)
            {
                EventAddScene(sceneName);
            }

            var scene = SceneManager.GetSceneByName(sceneName);
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        }

        internal void RemoveScene(string sceneName)
        {
            if (EventRemoveScene != null)
            {
                EventRemoveScene(sceneName);
            }

            var scene = SceneManager.GetSceneByName(sceneName);
            SceneManager.UnloadSceneAsync(scene);
        }
    }

}

