using System.Media;
using Assets.Scripts.ExtensionsAndUtilities;
using UnityEngine;

namespace Assets.Scripts
{
    public class Interact : MonoBehaviour {

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.IsPlayer())
            {
                SystemSounds.Asterisk.Play();
                Debug.Log("!!!!!");
            }
        }
    }
}
