using System;
using System.Media;
using Assets.Scripts.ExtensionsAndUtilities;
using Assets.Scripts.PlayerScripts;
using SurrealGame;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Interact : MonoBehaviour
    {
        public GameObject DialogueUI;
        public Text Text;

        private int _dialogueCounter = 0;

        public void AdvanceDialogue()
        {
            DialogueUI.SetActive(true);

            switch (_dialogueCounter)
            {
                case 0:
                    Text.text = "You dropped something.";
                    break;
                case 1:
                    Text.text = "Enjoy";
                    break;
                case 2:
                    GiveKey();
                    break;
                default:
                    break;
            }

            _dialogueCounter++;
        }

        private void GiveKey()
        {
            Debug.Log("!!!!!");
        }
    }
}
