using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SurrealGame
{

    public class Scene_Master : MonoBehaviour
    {
        private Player_Master playerMaster;

        public delegate void GoToSceneEventHandler(string scene);
        public event GoToSceneEventHandler GoToSceneEvent;

        public void CallGoToSceneEvent(string scene)
        {
            if (GoToSceneEvent != null)
            {
                GoToSceneEvent(scene);
            }
        }

        void SetInitialReferences()
        {

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

