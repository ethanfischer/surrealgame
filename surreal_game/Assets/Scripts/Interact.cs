using System;
using System.Media;
using Assets.Scripts.ExtensionsAndUtilities;
using Assets.Scripts.PlayerScripts;
using SurrealGame;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
//using VRTK;
//using VRTK.UnityEventHelper;
using Object = UnityEngine.Object;

namespace Assets.Scripts
{
    public class Interact : MonoBehaviour
    {
        public GameObject DialogueObject;
        public TextMesh TextMesh;

        private int _interactCount = 0;
        private int _dialogueCount = 0;

        public void Snap()
        {
            _dialogueCount = 1;
            //AdvanceDialogue();
        }

        private void GiveKey()
        {
            Player.Instance.GetComponentInChildren<PlayerInventoryVR>().Add(new GameObject("key"));
            SFX.Instance.PlaySoundEffect(SFX.SoundEffectType.AddToInventory);
        }
    }
}
