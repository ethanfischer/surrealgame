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
        public GameObject DialogueObject;
        public TextMesh TextMesh;

        private int _dialogueCounter = 0;

        public void AdvanceDialogue()
        {
            DialogueObject.SetActive(true);

            switch (_dialogueCounter)
            {
                case 0:
                    TextMesh.text = "You dropped something.";
                    break;
                case 1:
                    TextMesh.text = "Enjoy";
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
            Player.Instance.GetComponentInChildren<PlayerInventoryVR>().Add(new GameObject("key"));
            SFX.Instance.PlaySoundEffect(SFX.SoundEffectType.AddToInventory);
        }
    }
}
