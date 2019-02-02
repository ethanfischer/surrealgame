using System.Media;
using Assets.Scripts.Miscellaneous;
using UnityEngine;

namespace Assets.Scripts
{
    public class DestroyObjectsWithTag : MonoBehaviour
    {
        void OnTriggerEnter(Collider collider)
        {
            var go = collider.gameObject;
            if (go.tag != Tags.DISPOSABLE) return;

            Debug.Log(gameObject.name + "destroyed");
            SystemSounds.Asterisk.Play();
            GameObject.Destroy(go);
        }
    }
}
