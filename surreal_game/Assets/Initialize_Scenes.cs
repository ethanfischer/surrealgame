using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SurrealGame
{
    public class Initialize_Scenes : MonoBehaviour
    {
        public string scene;

        void Awake()
        {
            if(scene == null)
            {
                throw new Exception("No scene to initialize");
            }
            LoadSceneAdditively(scene);
        }

        private static void LoadSceneAdditively(string sceneName)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        }
    }
}
