using System;
using System.Media;
using Assets.Scripts.ExtensionsAndUtilities;
using Assets.Scripts.PlayerScripts;
using SurrealGame;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using VRTK;

namespace Assets.Scripts
{
    public class Interact : MonoBehaviour
    {
        public GameObject DialogueObject;
        public TextMesh TextMesh;

        //private VRTK_ControllerEvents ControllerEvents;

        private int _dialogueCounter = 0;

        private void Awake()
        {
            //ControllerEvents = Player.Instance.VRTK_SDKManager.scriptAliasRightController.GetComponent<VRTK_ControllerEvents>();
            //ControllerEvents.ButtonOnePressed += AdvanceDialogue;
        }

        public void AdvanceDialogue()
        {
            DialogueObject.SetActive(true);
            EditorApplication.Beep();

            switch (_dialogueCounter)
            {
                case 0:
                    TextMesh.text = "Hurry up. We're closing.";
                    break;
                case 1:
                    TextMesh.text = "Buy something or beat it.";
                    break;
                case 2:
                    TextMesh.text = "Take something, I don't care.";
                    break;
                default:
                    break;
            }

            _dialogueCounter++;
        }

        private void GiveKey()
        {
            Player.Instance.GetComponentInChildren<PlayerInventoryVR>().Add(new GameObject("key"));
            SFX.Instance.PlaySoundEffect(SFX.SoundEffectType.AddToInventory);
        }
    }
}
