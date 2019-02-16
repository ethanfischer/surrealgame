using Assets.Scripts.ExtensionsAndUtilities;
using UnityEngine;

namespace Assets.Scripts
{
    public class TurnOnFloor1Roomtone : MonoBehaviour
    {
        public AudioSource Floor1Roomtone;

        void OnTriggerEnter(Collider collider)
        {
            if (collider.IsPlayer())
            {
                Floor1Roomtone.Play();
            }
        }
    }
}
