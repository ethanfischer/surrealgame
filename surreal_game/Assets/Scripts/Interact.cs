using System;
using System.Media;
using Assets.Scripts.ExtensionsAndUtilities;
using Assets.Scripts.PlayerScripts;
using SurrealGame;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using VRTK;
using VRTK.UnityEventHelper;
using Object = UnityEngine.Object;

namespace Assets.Scripts
{
    public class Interact : MonoBehaviour
    {
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
                    Dialogue0();
                    break;
                case 1:
                    Dialogue1();
                    break;
                default:
                    break;
            }

            _interactCount++;
        }

        private void Dialogue0()
        {
            switch (_interactCount)
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
                    _interactCount = -1;
                    break;
                default:
                    break;
            }
        }

        private void Dialogue1()
        {
            switch (_interactCount)
            {
                case 0:
                    TextMesh.text = "Oh.";
                    break;
                case 1:
                    TextMesh.text = "That's the last one of those.";
                    break;
                case 2:
                    TextMesh.text = "I was gonna take that.";
                    break;
                case 3:
                    TextMesh.text = "Tell you what.";
                    break;
                case 4:
                    TextMesh.text = "I'll let you take that, if you do me a solid.";
                    break;
                case 5:
                    TextMesh.text = "Meet me in the bathroom.";
                    _interactCount = -1;
                    break;
                default:
                    break;
            }
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
