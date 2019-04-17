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

        public void AdvanceDialogue()
        {
            DialogueObject.SetActive(true);

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
                case 3:
                    TextMesh.text = "";
                    _dialogueCounter = -1;
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
