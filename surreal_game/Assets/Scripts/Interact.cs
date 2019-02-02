using System.Media;
using Assets.Scripts.ExtensionsAndUtilities;
using UnityEngine;

namespace Assets.Scripts
{
    public class Interact : MonoBehaviour
    {
        public event PlayerInteractionEvent PlayerInteractionEvent;

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.IsPlayer())
            {
                OnPlayerInteraction(new OnPlayerInteractionArgs());
                SystemSounds.Asterisk.Play();
                Debug.Log("!!!!!");
            }
        }

        protected virtual void OnPlayerInteraction(OnPlayerInteractionArgs args)
        {
            PlayerInteractionEvent?.Invoke(this, args);
        }
    }

    public delegate void PlayerInteractionEvent(object sender, OnPlayerInteractionArgs args);
}
