using Assets.Scripts.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Assets.Scripts
{
    public class DialogueService : MonoBehaviour
    {
        public string[] Lines;
        public UnityEvent PostLinesCallback; 
        public string[] Lines1;
        public UnityEvent PostLines1Callback; 

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
            bool hasReachedEnd = _interactCount >= lines.Length;
            if (hasReachedEnd)
            {
                TextMesh.text = "";
                _interactCount = 0;
                PostLinesCallback.Invoke();
            }

            TextMesh.text = lines[_interactCount];
        }

        public void NextDialogue()
        {
            Debug.Log("nextdialog");
            _dialogueCount++;
            _interactCount = 0;
            AdvanceDialogue();
        }

        private void GiveKey()
        {
            Player.Instance.GetComponentInChildren<PlayerInventoryVR>().Add(new GameObject("key"));
            SFX.Instance.PlaySoundEffect(SFX.SoundEffectType.AddToInventory);
        }
    }
}
