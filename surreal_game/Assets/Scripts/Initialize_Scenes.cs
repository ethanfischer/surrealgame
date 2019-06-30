using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Miscellaneous;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SurrealGame
{
    public class Initialize_Scenes : MonoBehaviour
    {
        void Awake()
        {
            //LoadSceneAdditively(Scenes.WEIRD_PLACE);
            LoadSceneAdditively(Scenes.GAS_STATION);
        }

        private static void LoadSceneAdditively(string sceneName)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        }
    }
}
