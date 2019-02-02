using System.Media;
using Assets.Scripts.Miscellaneous;
using UnityEngine;

namespace Assets.Scripts
{
    public class TriggerDerrickAppearance : MonoBehaviour
    {
        void OnTriggerEnter(Collider collider)
        {
            var go = collider.gameObject;
            if (go.tag != Tags.DISPOSABLE) return;

            Debug.Log("derick!!!!!");
            SystemSounds.Exclamation.Play();
        }
    }
}
