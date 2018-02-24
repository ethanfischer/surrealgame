using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SurrealGame
{
    public class Initialize_Scenes : MonoBehaviour
    {
        public string initialLocation = "Kitchen";

        void Awake()
        {
            LoadSceneAdditively(initialLocation);
        }

        private static void LoadSceneAdditively(string sceneName)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        }
    }
}
