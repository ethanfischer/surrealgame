﻿using System.IO;
using Assets.Scripts.PlayerScripts;
using UnityEngine;

namespace Assets.Scripts
{
    public class DialogueService : MonoBehaviour
    {
        public string[] Lines;
        public string[] Lines1;

        public GameObject DialogueObject;
        public TextMesh TextMesh;

        private int _interactCount = 0;
        private int _dialogueCount = 0;

        public void AdvanceDialogue()
        {
            DialogueObject.SetActive(true);

            switch (_dialogueCount)
            {
                case 0:
                    Dialogue(Lines);
                    break;
                case 1:
                    Dialogue(Lines1);
                    break;
                default:
                    break;
            }

            _interactCount++;
        }

        private void Dialogue(string[] lines)
        {
            bool hasReachedEnd = _interactCount >= Lines.Length;
            if (hasReachedEnd)
            {
                TextMesh.text = "";
                _interactCount = -1;
            }

            TextMesh.text = lines[_interactCount];
        }

        public void Snap()
        {
            _dialogueCount = 1;
            AdvanceDialogue();
        }

        private void GiveKey()
        {
            Player.Instance.GetComponentInChildren<PlayerInventoryVR>().Add(new GameObject("key"));
            SFX.Instance.PlaySoundEffect(SFX.SoundEffectType.AddToInventory);
        }
    }
}
