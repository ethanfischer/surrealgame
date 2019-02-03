using System.Media;
using Assets.Scripts.ExtensionsAndUtilities;
using Assets.Scripts.PlayerScripts;
using SurrealGame;
using UnityEngine;

namespace Assets.Scripts
{
    public class Interact : MonoBehaviour
    {
        public GameObject DialogueUI;

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.IsPlayer())
            {
                DialogueUI.SetActive(true);
            }
        }
    }
}
