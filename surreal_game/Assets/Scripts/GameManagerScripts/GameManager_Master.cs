using UnityEngine;
using System.Collections;

namespace SurrealGame
{
    public class GameManager_Master : MonoBehaviour
    {

        public delegate void GameManagerEventHandler();

        public event GameManagerEventHandler MenuToggleEvent;
        public event GameManagerEventHandler InventoryUIToggleEvent;
        public event GameManagerEventHandler RestartLevelEvent;
        public event GameManagerEventHandler GoToMenuSceneEvent;
        public event GameManagerEventHandler GameOverEvent;
        public event GameManagerEventHandler CutsceneTerminatedEvent;
        public event GameManagerEventHandler ExamineObjectEvent;

        public bool isGameOver;
        public bool isInventoryUIOn;
        public bool isMenuOn;


        public void CallEventMenuToggle()
        {
            if (MenuToggleEvent != null)
            {
                MenuToggleEvent();
            }
            //Debug.Log("CallventMenuToggle");
        }

        public void CallEventInventoryUIToggle()
        {
            if (InventoryUIToggleEvent != null)
            {
                InventoryUIToggleEvent();
            }
        }

        public void CallEventRestartLevel()
        {
            if (InventoryUIToggleEvent != null)
            {
                RestartLevelEvent();
            }
        }

        public void CallEventGoToMenuScene()
        {
            if (GoToMenuSceneEvent != null)
            {
                GoToMenuSceneEvent();
            }
        }

        public void CallEventGameOver()
        {
            if (GameOverEvent != null)
            {
                isGameOver = true;
                GameOverEvent();
            }
        }

        public void CallCutsceneTerminatedEvent()
        {
            if (CutsceneTerminatedEvent != null)
            {
                CutsceneTerminatedEvent();
            }
        }

        public void CallExamineObjectEvent()
        {
            if (ExamineObjectEvent != null)
            {
                ExamineObjectEvent();
            }
        }
    }
}


